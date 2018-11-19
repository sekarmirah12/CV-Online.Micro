namespace CVOnline.Micro.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Client_Education",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        clients_Id = c.Int(),
                        educations_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.clients_Id)
                .ForeignKey("dbo.Educations", t => t.educations_Id)
                .Index(t => t.clients_Id)
                .Index(t => t.educations_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Place = c.String(),
                        Birthday = c.DateTimeOffset(nullable: false, precision: 7),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Password = c.String(),
                        Cv = c.String(),
                        Ktp = c.String(),
                        Foto = c.String(),
                        villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Villages", t => t.villages_Id)
                .Index(t => t.villages_Id);
            
            CreateTable(
                "dbo.Villages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        districts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.districts_Id)
                .Index(t => t.districts_Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        regencies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regencies", t => t.regencies_Id)
                .Index(t => t.regencies_Id);
            
            CreateTable(
                "dbo.Regencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        provinces_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.provinces_Id)
                .Index(t => t.provinces_Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Education_Level",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Length = c.Int(nullable: false),
                        client_Id = c.Int(),
                        Company_Id = c.Int(),
                        Position_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.client_Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .Index(t => t.client_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        categories_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.categories_Id)
                .Index(t => t.categories_Id);
            
            CreateTable(
                "dbo.History_Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        client_Id = c.Int(),
                        job_detail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.client_Id)
                .ForeignKey("dbo.Job_Detail", t => t.job_detail_Id)
                .Index(t => t.client_Id)
                .Index(t => t.job_detail_Id);
            
            CreateTable(
                "dbo.Job_Detail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Position = c.String(),
                        Type = c.String(),
                        Last_Education = c.String(),
                        Max_Age = c.Int(nullable: false),
                        Work_Experience = c.String(),
                        Salary = c.Int(nullable: false),
                        Company = c.String(),
                        job_creators_Id = c.Int(),
                        Villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Job_Creator", t => t.job_creators_Id)
                .ForeignKey("dbo.Villages", t => t.Villages_Id)
                .Index(t => t.job_creators_Id)
                .Index(t => t.Villages_Id);
            
            CreateTable(
                "dbo.Job_Creator",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        companies_Id = c.Int(),
                        types_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.companies_Id)
                .ForeignKey("dbo.Types", t => t.types_Id)
                .Index(t => t.companies_Id)
                .Index(t => t.types_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Schedule = c.DateTimeOffset(nullable: false, precision: 7),
                        Result = c.String(),
                        villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Villages", t => t.villages_Id)
                .Index(t => t.villages_Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.client_Id)
                .Index(t => t.client_Id);
            
            CreateTable(
                "dbo.Searches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.client_Id)
                .Index(t => t.client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "client_Id", "dbo.Clients");
            DropForeignKey("dbo.Languages", "client_Id", "dbo.Clients");
            DropForeignKey("dbo.Interviews", "villages_Id", "dbo.Villages");
            DropForeignKey("dbo.History_Client", "job_detail_Id", "dbo.Job_Detail");
            DropForeignKey("dbo.Job_Detail", "Villages_Id", "dbo.Villages");
            DropForeignKey("dbo.Job_Detail", "job_creators_Id", "dbo.Job_Creator");
            DropForeignKey("dbo.Job_Creator", "types_Id", "dbo.Types");
            DropForeignKey("dbo.Job_Creator", "companies_Id", "dbo.Companies");
            DropForeignKey("dbo.History_Client", "client_Id", "dbo.Clients");
            DropForeignKey("dbo.Experiences", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Positions", "categories_Id", "dbo.Categories");
            DropForeignKey("dbo.Experiences", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Experiences", "client_Id", "dbo.Clients");
            DropForeignKey("dbo.Client_Education", "educations_Id", "dbo.Educations");
            DropForeignKey("dbo.Client_Education", "clients_Id", "dbo.Clients");
            DropForeignKey("dbo.Clients", "villages_Id", "dbo.Villages");
            DropForeignKey("dbo.Villages", "districts_Id", "dbo.Districts");
            DropForeignKey("dbo.Districts", "regencies_Id", "dbo.Regencies");
            DropForeignKey("dbo.Regencies", "provinces_Id", "dbo.Provinces");
            DropIndex("dbo.Skills", new[] { "client_Id" });
            DropIndex("dbo.Languages", new[] { "client_Id" });
            DropIndex("dbo.Interviews", new[] { "villages_Id" });
            DropIndex("dbo.Job_Creator", new[] { "types_Id" });
            DropIndex("dbo.Job_Creator", new[] { "companies_Id" });
            DropIndex("dbo.Job_Detail", new[] { "Villages_Id" });
            DropIndex("dbo.Job_Detail", new[] { "job_creators_Id" });
            DropIndex("dbo.History_Client", new[] { "job_detail_Id" });
            DropIndex("dbo.History_Client", new[] { "client_Id" });
            DropIndex("dbo.Positions", new[] { "categories_Id" });
            DropIndex("dbo.Experiences", new[] { "Position_Id" });
            DropIndex("dbo.Experiences", new[] { "Company_Id" });
            DropIndex("dbo.Experiences", new[] { "client_Id" });
            DropIndex("dbo.Regencies", new[] { "provinces_Id" });
            DropIndex("dbo.Districts", new[] { "regencies_Id" });
            DropIndex("dbo.Villages", new[] { "districts_Id" });
            DropIndex("dbo.Clients", new[] { "villages_Id" });
            DropIndex("dbo.Client_Education", new[] { "educations_Id" });
            DropIndex("dbo.Client_Education", new[] { "clients_Id" });
            DropTable("dbo.Skills");
            DropTable("dbo.Searches");
            DropTable("dbo.Languages");
            DropTable("dbo.Interviews");
            DropTable("dbo.Types");
            DropTable("dbo.Job_Creator");
            DropTable("dbo.Job_Detail");
            DropTable("dbo.History_Client");
            DropTable("dbo.Positions");
            DropTable("dbo.Experiences");
            DropTable("dbo.Education_Level");
            DropTable("dbo.Companies");
            DropTable("dbo.Educations");
            DropTable("dbo.Provinces");
            DropTable("dbo.Regencies");
            DropTable("dbo.Districts");
            DropTable("dbo.Villages");
            DropTable("dbo.Clients");
            DropTable("dbo.Client_Education");
            DropTable("dbo.Categories");
            DropTable("dbo.Admins");
        }
    }
}
