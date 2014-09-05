namespace CRMData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreateBy = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(),
                        UpdateBy = c.Int(nullable: false),
                        UpdateDateTime = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Plate = c.String(),
                        BrandId = c.Int(nullable: false),
                        Model = c.String(),
                        FuelType = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        PricePerDay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        CreateBy = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(),
                        UpdateBy = c.Int(nullable: false),
                        UpdateDateTime = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Branch", t => t.BranchId)
                .ForeignKey("dbo.Brand", t => t.BrandId)
                .Index(t => t.BrandId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateBy = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(),
                        UpdateBy = c.Int(nullable: false),
                        UpdateDateTime = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CreateBy = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(),
                        UpdateBy = c.Int(nullable: false),
                        UpdateDateTime = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Member", t => t.MemberId)
                .ForeignKey("dbo.Vehicle", t => t.VehicleId)
                .Index(t => t.MemberId)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameSurName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        CreateBy = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(),
                        UpdateBy = c.Int(nullable: false),
                        UpdateDateTime = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Event", "VehicleId", "dbo.Vehicle");
            DropForeignKey("dbo.Event", "MemberId", "dbo.Member");
            DropForeignKey("dbo.Vehicle", "BrandId", "dbo.Brand");
            DropForeignKey("dbo.Vehicle", "BranchId", "dbo.Branch");
            DropIndex("dbo.Event", new[] { "VehicleId" });
            DropIndex("dbo.Event", new[] { "MemberId" });
            DropIndex("dbo.Vehicle", new[] { "BranchId" });
            DropIndex("dbo.Vehicle", new[] { "BrandId" });
            DropTable("dbo.Member");
            DropTable("dbo.Event");
            DropTable("dbo.Brand");
            DropTable("dbo.Vehicle");
            DropTable("dbo.Branch");
        }
    }
}
