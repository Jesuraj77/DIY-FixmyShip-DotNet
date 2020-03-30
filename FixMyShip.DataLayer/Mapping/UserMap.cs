using FixMyShip.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.DataLayer.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {

            Id(x => x.UserId);

            Map(x => x.UserName);

            Map(x => x.Email);
            Map(x => x.Password);

            Table("User");

        }
    }
}
