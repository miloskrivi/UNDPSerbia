namespace UNDPSerbia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceContractsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceContracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SCNumber = c.Int(nullable: false),
                        SCYear = c.Int(nullable: false),
                        AmendmentNo = c.Int(nullable: false),
                        ContractDate = c.DateTime(nullable: false),
                        OnBehalf = c.String(maxLength: 50),
                        EmployeeId = c.Int(nullable: false),
                        ContractorAddress = c.String(maxLength: 150),
                        ContractorPhone = c.String(maxLength: 30),
                        ContractStart = c.DateTime(nullable: false),
                        ContractEnd = c.DateTime(nullable: false),
                        RemunerationAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RemunerationCurrency = c.String(nullable: false, maxLength: 3),
                        BeneficiaryName = c.String(maxLength: 50),
                        BeneficiaryAddress = c.String(maxLength: 150),
                        UNDPSignatory = c.String(maxLength: 150),
                        AccountNumber = c.String(maxLength: 200),
                        KeepAttendRec = c.Boolean(),
                        LastUpdate = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 30),
                        LocationID = c.Int(),
                        ProjectGroup1 = c.Int(),
                        Percentage1 = c.Int(),
                        ProjectGroup2 = c.Int(),
                        Percentage2 = c.Int(),
                        ProjectGroup3 = c.Int(),
                        Percentage3 = c.Int(),
                        TwoMonthsReminder = c.DateTime(),
                        BuildingID = c.Int(),
                        DutyStation = c.String(maxLength: 50),
                        EmailRequestID = c.Int(),
                        PBDate = c.DateTime(),
                        ISScharges = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceContracts", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.ServiceContracts", new[] { "EmployeeId" });
            DropTable("dbo.ServiceContracts");
        }
    }
}
