using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WideWorld.Models;

namespace WideWorld.Data
{
    public class DbInitializer
    {
        public static void Initialize(WideWorldContext context)
        {
            context.Database.EnsureCreated();

            string insertSqlCmd;
            System.IO.StreamReader file;
            // Check for previously populated Countries table
            if (!context.Countries.Any())
            {
                // Insert Countries
                file = new System.IO.StreamReader(".\\Data\\InsertCountries.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert Application.Countries ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert Application.Countries OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            if (!context.StateProvinces.Any())
            {
                // Insert StateProvinces
                file = new System.IO.StreamReader(".\\Data\\InsertStateProvinces.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert Application.StateProvinces ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert Application.StateProvinces OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            if (!context.Cities.Any())
            {
                // Insert Cities
                file = new System.IO.StreamReader(".\\Data\\InsertCities.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert Application.Cities ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert Application.Cities OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            // Load Users using SQL INSERT commands
            // Check for previously populated Users table
            if (!context.Users.Any())
            {
                // Insert Users
                file = new System.IO.StreamReader(".\\Data\\InsertUsers.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert Users ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert Users OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }            

            // Load People using SQL INSERT commands
            // Check for previously populated People table
            if (!context.People.Any())
            {
                // Insert People
                file = new System.IO.StreamReader(".\\Data\\InsertPeople.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert People ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert People OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            // Load OrgRoles using SQL INSERT commands
            // Check for previously populated OrgRoles table
            if (!context.OrgRoles.Any())
            {
                // Insert OrRoles
                file = new System.IO.StreamReader(".\\Data\\InsertOrgRoles.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert OrgRoles ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert OrgRoles OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            // Load Organizations using SQL INSERT commands
            // Check for previously populated Organizations table
            if (!context.Organizations.Any())
            {
                // Insert Organizations
                file = new System.IO.StreamReader(".\\Data\\InsertOrganizations.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert Organizations ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert Organizations OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            // Load OrgLocations using SQL INSERT commands
            // Check for previously populated OrgLocations table
            if (!context.OrgLocations.Any())
            {
                // Insert OrgLocations
                file = new System.IO.StreamReader(".\\Data\\InsertOrgLocations.sql");
                while ((insertSqlCmd = file.ReadLine()) != null)
                {
                    context.RawSqlReturn.FromSql("set identity_insert OrgLocations ON; " + insertSqlCmd + "select 1 as Id;").ToList();
                }
                file.Close();
                context.RawSqlReturn.FromSql("set identity_insert OrgLocations OFF; select 1 as Id;").ToList();
                context.SaveChanges();
            }

            if (!context.PeopleOrgs.Any()) {
                PersonOrg[] peopleOrgs = new PersonOrg[] {
                    new PersonOrg { PersonId = 1017, OrgId = 934, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 1017, OrgId = 1934, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 1017, OrgId = 642, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 2147, OrgId = 1934, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 2147, OrgId = 642, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 2147, OrgId = 302, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 3044, OrgId = 642, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 3044, OrgId = 302, LastEditedBy = 1 },
                    new PersonOrg { PersonId = 3044, OrgId = 930, LastEditedBy = 1 }
                };

                foreach (PersonOrg po in peopleOrgs) {
                    context.PeopleOrgs.Add(po);
                }
                context.SaveChanges();
            }
        }
    }
}
