namespace mvcEticaret.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAdi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "UrunGorsel", c => c.String(maxLength: 250, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "UrunGorsel", c => c.String(maxLength: 30, unicode: false));
        }
    }
}
