﻿using EHR.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.User.Entities
{
    public class User : EditableEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<EmergancyContact> EmergancyContacts { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Role> Roles { get; set; }
        //public ICollection<UserAttribute> Attributes { get; set; }
    }

    //public class UserAttribute : XRefEntity
    //{
    //    public bool Required { get; set; }
    //    public UserAttributeType Type { get; set; }
    //    public UserAttributeGroup Group { get; set; }
    //}

    //public class UserAttributeType : TypeEntity
    //{

    //}

    //public class UserAttributeGroup : TypeEntity
    //{

    //}

    public class EmergancyContact : EditableEntity
    {
        public User Contact { get; set; }
        public EmergancyContactType Type { get; set; }
    }

    public class EmergancyContactType : TypeEntity
    {
    }

    public class Role : EditableEntity
    {
        ICollection<Permission> Permissions { get; set; }
    }

    public class Permission : TypeEntity
    {
        public Action Action { get; set; }
        public Module Module { get; set; }
    }

    public enum Action
    {
        Edit,
        View,
        Delete,
        Add,
        Submit,
        Approve,
        Reject
    }

    public class Module : TypeEntity
    {

    }
}