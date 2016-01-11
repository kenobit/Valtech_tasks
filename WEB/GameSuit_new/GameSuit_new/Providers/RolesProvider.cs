using GameSuit_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Helpers;
using System.Web.WebPages;
using Microsoft.Internal.Web.Utils;

namespace GameSuit_new.Providers
{
    public class RolesProvider : RoleProvider
    {
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string login)
        {
            string[] role = new string[] { };
            using (UserContext context = new UserContext())
            {
                try
                {
                    User user = (from u in context.Users
                                 where u.Login == login
                                 select u).FirstOrDefault();
                    if (user!=null)
                    {
                        Role userRole = context.Roles.Find(user.RoleId);

                        if (userRole!=null)
                        {
                            role = new string[] { userRole.Name };
                        }
                    }
                }
                catch (Exception)
                {
                    role = new string[] { };
                }
            }
            return role;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string login, string roleName)
        {
            bool outputResult = false;
            using (UserContext context = new UserContext())
            {
                try
                {
                    User user = (from u in context.Users
                                 where u.Login == login
                                 select u).FirstOrDefault();
                    if (user!=null)
                    {
                        Role userRole = context.Roles.Find(user.RoleId);
                        if (userRole!= null && userRole.Name == roleName)
                        {
                            outputResult = true;
                        }
                    }
                }
                catch (Exception)
                {
                    outputResult = false;
                }
            }
            return outputResult;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}