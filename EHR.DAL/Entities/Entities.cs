using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Entities
{
    public class AuthToken : TokenEntity
    {
    }

    public class User : ManagedEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string DOB { get; set; }

        public ICollection<RoleMembership> RoleMemberships { get; set; }
        public ICollection<UserStatusHistory> UserStatusHistory { get; set; }
    }

    public class UserEmail : ManagedEntity
    {
        public bool Primary { get; set; }

        public User User { get; set; }
        public Email Email { get; set; }
        public UserEmailType UserEmailType { get; set; }
    }

    public enum UserEmailType
    {
        Personal = 1,
        Work = 2,
        Other = 3
    }

    public class UserAddress : ManagedEntity
    {
        public bool Primary { get; set; }

        public User User { get; set; }
        public Address Address { get; set; }
        public UserAddressType UserAddressType { get; set; }
    }

    public enum UserAddressType
    {
        Home = 1,
        Work = 2,
        Other = 3
    }

    public class UserStatusHistory : HistoricalEntity
    {
        public User User { get; set; }
        public UserStatusType UserStatusType { get; set; }
    }

    public class UserStatusType : TypeEntity
    {
    }

    public class RoleMembership : ManagedEntity
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }

    public class Role : ManagedEntity
    {
        public string Name { get; set; }

        public ICollection<RoleMembership> Memberships { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }

    public class Permission : ManagedEntity
    {
        public Role Role { get; set; }      //These users
        public Action Action { get; set; }  //can perform this action
        public Scope Scope { get; set; }    //within these bounds
        public Module Module { get; set; }  //to these objects
    }

    public class Module : TypeEntity
    {
    }

    public class Action : TypeEntity
    {
    }

    public class Scope : TypeEntity
    {
    }

    public class SystemSetting : ManagedEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Default { get; set; }

        public SystemSettingType SystemSettingType { get; set; }
        public Module Module { get; set; }

        public ICollection<SystemSettingOption> SystemSettingOptions { get; set; }
    }

    public class SystemSettingType : TypeEntity
    {
    }

    public class SystemSettingOption : ManagedEntity
    {
        public SystemSetting SystemSetting { get; set; }
    }

    public class Country : ManagedEntity
    {
    }

    public class State_Province : ManagedEntity
    {
    }

    public class Address : ManagedEntity
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public State_Province State { get; set; }
        public string ZipCode { get; set; }
        public Country Country { get; set; }
    }

    public class Email : ManagedEntity
    {
        public string EmailAddress { get; set; }
    }
}
