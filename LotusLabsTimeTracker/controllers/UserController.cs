﻿using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.services;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data;

namespace LotusLabsTimeTracker.controllers
{
    class UserController
    {
        private String saltKey = "LOTUS";
        private static string defaultPassword = "password@1234";

        public IList<UserType> getUserTypes()
        {
            return getLookupBean().getUserTypes(false);
        }

        public void createUser(Users user)
        {
            user.password = this.generateHashPassword(defaultPassword);
            user.invalid_login = 0;
            user.createdBy = 0L;
            user.createdDate = DateTime.Now;
            user.updatedBy = 0L;
            user.updatedDate = DateTime.Now;
            user.activeFlag = true;
            getUserBean().saveUser(user);
        }

        public void updateUser(Users user)
        {
            user.updatedBy = user.id;
            user.updatedDate = DateTime.Now;
            user.last_login = DateTime.Now;
            getUserBean().saveUser(user);
        }

        public List<String> validateUserLogin(String username, String password)
        {
            List<String> errMessages = new List<string>();
            if (String.IsNullOrEmpty(username))
            {
                errMessages.Add("Employee ID is required");
            }

            if (String.IsNullOrEmpty(password))
            {
                errMessages.Add("Password is required");
            }

            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                String hashedPassword = generateHashPassword(password);
                Users users = getUserBean().getUsersByUsername(username, hashedPassword);
                if (users == null || users.id == 0)
                {
                    errMessages.Add("Invalid EmployeeID/Password");
                }
            }
            return errMessages;
        }

        public Users getUserDetails(String username)
        {
            return getUserBean().getUsersByUsername(username);
        }

        public List<String> validateUser(Users users, bool isNew)
        {
            List<String> errMessages = new List<String>();
            if (users.usertype.id == 0)
            {
                errMessages.Add("User Type is required");
            }
            if (String.IsNullOrEmpty(users.username))
            {
                errMessages.Add("Employee ID is required");
            }
            else
            {
                //true if user already exist
                //check if employee number already exist
                if (getUserBean().validateEmployeeNoIfExist(users.username)&&isNew)
                {
                    errMessages.Add("Employee ID already exist in the system");
                }
            }
            if (String.IsNullOrEmpty(users.firstName))
            {
                errMessages.Add("Firstname is required");
            }
            if (String.IsNullOrEmpty(users.lastName))
            {
                errMessages.Add("Lastname is required");
            }
            if (String.IsNullOrEmpty(users.email))
            {
                errMessages.Add("Email is required");
            }
            return errMessages;
        }

        public List<String> validatePassword(String password, String confirmPassword)
        {
            List<String> errMessages = new List<String>();
            if (password == null || confirmPassword == null)
            {
                errMessages.Add("New password/Confirm password is required");
            }
            else
            {
                if (password.Length < 8)
                {
                    errMessages.Add("Password should be atleast 8 character");
                    return errMessages;
                }
                if (!password.Equals(confirmPassword))
                {
                    errMessages.Add("New password/Confirm password must be equal");
                    return errMessages;
                }
                Regex regex = new Regex("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&+=]).*$");
                Match match = regex.Match(password);
                if (!match.Success)
                {
                    errMessages.Add("Password should contain atleast 1 upper case, 1 lower case, 1 number and 1 special character");
                }
            }
            return errMessages;
        }

        public string generateHashPassword(String password)
        {
            HashAlgorithm algo = new SHA256Managed();
            byte[] passByte = System.Text.Encoding.Unicode.GetBytes(password);
            byte[] saltKeyByte = System.Text.Encoding.Unicode.GetBytes(this.saltKey);
            byte[] concatinatedPassAndSalt = new byte[passByte.Length + saltKeyByte.Length];
            for (int i = 0; i < passByte.Length; i++)
            {
                concatinatedPassAndSalt[i] = passByte[i];
            }
            for (int i = 0; i < saltKeyByte.Length; i++)
            {
                concatinatedPassAndSalt[passByte.Length + i] = saltKeyByte[i];
            }
            return Convert.ToBase64String(algo.ComputeHash(concatinatedPassAndSalt));
        }


        public IList<Users> getUsersList(UserType userType, Users supervisor)
        {
            return getUserBean().getUsersList(userType, supervisor);
        }

        public DataTable getUsersDataTable(UserType userType, Users supervisor)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Employee Number");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Middle Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Position");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Supervisor");
            dataTable.Columns.Add(new DataColumn("Status", typeof(bool)));

            if (getUsersList(userType, supervisor).Count > 0)
            {
                foreach (Users users in getUsersList(userType, supervisor))
                {
                    dataTable.Rows.Add(new object[] { users.id,
                                                      users.username,
                                                      users.firstName,
                                                      users.middleName,
                                                      users.lastName,
                                                      users.usertype.name,
                                                      users.email,
                                                      getFullName(users.supervisor),
                                                      users.activeFlag
                    });
                }
            }
            return dataTable;
        }

        private LookupBean getLookupBean()
        {
            return new LookupBean();
        }

        private UserBean getUserBean()
        {
            return new UserBean();
        }


        public String getFullName(Users user)
        {
            if (user != null)
            {
                return user.lastName + ", " + user.firstName + " " + user.middleName;
            }
            return "";
        }

        public IList<Users> getUsersListPerUserType(String userTypes)
        {
            return getUserBean().getUsersListPerUserType(userTypes);
        }

        public Users getUserDetails(long id) {
            return getUserBean().getUserDetails(id);
        }

        public IList<Users> getUsersByRank(Users users) {
            return getUserBean().getUsersByRank(users);
        }

    }
}
