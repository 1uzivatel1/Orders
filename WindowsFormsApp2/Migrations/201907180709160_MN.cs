namespace WindowsFormsApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MN : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "Product_Id", "dbo.Products");
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropIndex("dbo.OrderItems", new[] { "Product_Id" });
            CreateTable(
                "dbo.OrderItemOrders",
                c => new
                    {
                        OrderItem_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderItem_Id, t.Order_Id })
                .ForeignKey("dbo.OrderItems", t => t.OrderItem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.OrderItem_Id)
                .Index(t => t.Order_Id);
            
            AlterColumn("dbo.OrderItems", "Product_Id", c => c.Int());
            CreateIndex("dbo.OrderItems", "Product_Id");
            AddForeignKey("dbo.OrderItems", "Product_Id", "dbo.Products", "Id");
            DropColumn("dbo.OrderItems", "Order_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Order_Id", c => c.Int());
            DropForeignKey("dbo.OrderItems", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderItemOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderItemOrders", "OrderItem_Id", "dbo.OrderItems");
            DropIndex("dbo.OrderItemOrders", new[] { "Order_Id" });
            DropIndex("dbo.OrderItemOrders", new[] { "OrderItem_Id" });
            DropIndex("dbo.OrderItems", new[] { "Product_Id" });
            AlterColumn("dbo.OrderItems", "Product_Id", c => c.Int(nullable: false));
            DropTable("dbo.OrderItemOrders");
            CreateIndex("dbo.OrderItems", "Product_Id");
            CreateIndex("dbo.OrderItems", "Order_Id");
            AddForeignKey("dbo.OrderItems", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders", "Id");
        }
    }
}
