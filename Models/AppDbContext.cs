using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Smart_ERP_System.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DimAccount> DimAccounts { get; set; }

    public virtual DbSet<DimCampaign> DimCampaigns { get; set; }

    public virtual DbSet<DimCompany> DimCompanies { get; set; }

    public virtual DbSet<DimDate> DimDates { get; set; }

    public virtual DbSet<DimDepartment> DimDepartments { get; set; }

    public virtual DbSet<DimEmployee> DimEmployees { get; set; }

    public virtual DbSet<DimInventory> DimInventories { get; set; }

    public virtual DbSet<DimJob> DimJobs { get; set; }

    public virtual DbSet<DimJournal> DimJournals { get; set; }

    public virtual DbSet<DimLead> DimLeads { get; set; }

    public virtual DbSet<DimLostReason> DimLostReasons { get; set; }

    public virtual DbSet<DimPartner> DimPartners { get; set; }

    public virtual DbSet<DimProduct> DimProducts { get; set; }

    public virtual DbSet<DimProductCombo> DimProductCombos { get; set; }

    public virtual DbSet<DimProductPricelist> DimProductPricelists { get; set; }

    public virtual DbSet<DimStage> DimStages { get; set; }

    public virtual DbSet<DimTeam> DimTeams { get; set; }

    public virtual DbSet<DimWarehouse> DimWarehouses { get; set; }

    public virtual DbSet<FactCrmPipeline> FactCrmPipelines { get; set; }

    public virtual DbSet<FactEmployeeSnapshot> FactEmployeeSnapshots { get; set; }

    public virtual DbSet<FactGlTransaction> FactGlTransactions { get; set; }

    public virtual DbSet<FactInventoryMovement> FactInventoryMovements { get; set; }

    public virtual DbSet<FactInventorySnapshot> FactInventorySnapshots { get; set; }

    public virtual DbSet<FactInvoice> FactInvoices { get; set; }

    public virtual DbSet<FactPurchaseOrder> FactPurchaseOrders { get; set; }

    public virtual DbSet<FactSale> FactSales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=finalErp;Username=postgres;Password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DimAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("dim_account_pkey");

            entity.ToTable("dim_account", "gold");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("account_id");
            entity.Property(e => e.AccountCategory)
                .HasColumnType("character varying")
                .HasColumnName("account_category");
            entity.Property(e => e.AccountCode)
                .HasColumnType("character varying")
                .HasColumnName("account_code");
            entity.Property(e => e.AccountName)
                .HasColumnType("character varying")
                .HasColumnName("account_name");
            entity.Property(e => e.AccountType)
                .HasColumnType("character varying")
                .HasColumnName("account_type");
            entity.Property(e => e.DwhLoadedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsReconcilable).HasColumnName("is_reconcilable");
        });

        modelBuilder.Entity<DimCampaign>(entity =>
        {
            entity.HasKey(e => e.CampaignKey).HasName("dim_campaign_pkey");

            entity.ToTable("dim_campaign", "gold");

            entity.HasIndex(e => e.CampaignId, "dim_campaign_campaign_id_key").IsUnique();

            entity.HasIndex(e => e.CampaignId, "idx_dim_campaign");

            entity.Property(e => e.CampaignKey).HasColumnName("campaign_key");
            entity.Property(e => e.CampaignId).HasColumnName("campaign_id");
            entity.Property(e => e.CampaignName).HasColumnName("campaign_name");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
        });

        modelBuilder.Entity<DimCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("dim_company_pkey");

            entity.ToTable("dim_company", "gold");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.FirstSeenSource)
                .HasMaxLength(64)
                .HasColumnName("first_seen_source");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DimDate>(entity =>
        {
            entity.HasKey(e => e.FullDate).HasName("dim_date_pkey");

            entity.ToTable("dim_date", "gold");

            entity.Property(e => e.FullDate).HasColumnName("full_date");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DayName)
                .HasMaxLength(20)
                .HasColumnName("day_name");
            entity.Property(e => e.DayOfMonth).HasColumnName("day_of_month");
            entity.Property(e => e.DayOfWeek).HasColumnName("day_of_week");
            entity.Property(e => e.IsWeekend).HasColumnName("is_weekend");
            entity.Property(e => e.MonthName)
                .HasMaxLength(20)
                .HasColumnName("month_name");
            entity.Property(e => e.MonthNumber).HasColumnName("month_number");
            entity.Property(e => e.QuarterNumber).HasColumnName("quarter_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.WeekOfYear).HasColumnName("week_of_year");
            entity.Property(e => e.YearNumber).HasColumnName("year_number");
        });

        modelBuilder.Entity<DimDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentKey).HasName("dim_department_pkey");

            entity.ToTable("dim_department", "gold");

            entity.HasIndex(e => e.DepartmentId, "dim_department_department_id_key").IsUnique();

            entity.HasIndex(e => e.ParentDepartmentId, "idx_dim_department_parent");

            entity.Property(e => e.DepartmentKey).HasColumnName("department_key");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DepartmentName).HasColumnName("department_name");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.ParentDepartmentId).HasColumnName("parent_department_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DimEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeKey).HasName("dim_employee_pkey");

            entity.ToTable("dim_employee", "gold");

            entity.HasIndex(e => e.EmployeeId, "dim_employee_employee_id_key").IsUnique();

            entity.HasIndex(e => e.ManagerId, "idx_dim_employee_manager");

            entity.Property(e => e.EmployeeKey).HasColumnName("employee_key");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.CoachId).HasColumnName("coach_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EmployeeName).HasColumnName("employee_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DimInventory>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("dim_inventory_pkey");

            entity.ToTable("dim_inventory", "gold");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("location_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LocationName).HasColumnName("location_name");
            entity.Property(e => e.LocationPath).HasColumnName("location_path");
            entity.Property(e => e.LocationType).HasColumnName("location_type");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            entity.Property(e => e.WarehouseName).HasColumnName("warehouse_name");
        });

        modelBuilder.Entity<DimJob>(entity =>
        {
            entity.HasKey(e => e.JobKey).HasName("dim_job_pkey");

            entity.ToTable("dim_job", "gold");

            entity.HasIndex(e => e.JobId, "dim_job_job_id_key").IsUnique();

            entity.Property(e => e.JobKey).HasColumnName("job_key");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobName).HasColumnName("job_name");
            entity.Property(e => e.NoOfRecruitment).HasColumnName("no_of_recruitment");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DimJournal>(entity =>
        {
            entity.HasKey(e => e.JournalId).HasName("dim_journal_pkey");

            entity.ToTable("dim_journal", "gold");

            entity.Property(e => e.JournalId)
                .ValueGeneratedNever()
                .HasColumnName("journal_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.JournalCode)
                .HasColumnType("character varying")
                .HasColumnName("journal_code");
            entity.Property(e => e.JournalName)
                .HasColumnType("character varying")
                .HasColumnName("journal_name");
            entity.Property(e => e.JournalType)
                .HasColumnType("character varying")
                .HasColumnName("journal_type");
        });

        modelBuilder.Entity<DimLead>(entity =>
        {
            entity.HasKey(e => e.LeadKey).HasName("dim_lead_pkey");

            entity.ToTable("dim_lead", "gold");

            entity.HasIndex(e => e.LeadId, "dim_lead_lead_id_key").IsUnique();

            entity.Property(e => e.LeadKey).HasColumnName("lead_key");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.LeadId).HasColumnName("lead_id");
            entity.Property(e => e.LeadName).HasColumnName("lead_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DimLostReason>(entity =>
        {
            entity.HasKey(e => e.LostReasonKey).HasName("dim_lost_reason_pkey");

            entity.ToTable("dim_lost_reason", "gold");

            entity.HasIndex(e => e.LostReasonId, "dim_lost_reason_lost_reason_id_key").IsUnique();

            entity.Property(e => e.LostReasonKey).HasColumnName("lost_reason_key");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.LostReasonId).HasColumnName("lost_reason_id");
            entity.Property(e => e.LostReasonName).HasColumnName("lost_reason_name");
        });

        modelBuilder.Entity<DimPartner>(entity =>
        {
            entity.HasKey(e => e.PartnerId).HasName("dim_partner_pkey");

            entity.ToTable("dim_partner", "gold");

            entity.Property(e => e.PartnerId)
                .ValueGeneratedNever()
                .HasColumnName("partner_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CommercialPartnerId).HasColumnName("commercial_partner_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CustomerRank).HasColumnName("customer_rank");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IndustryId).HasColumnName("industry_id");
            entity.Property(e => e.IsCompany).HasColumnName("is_company");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.PartnerName).HasColumnName("partner_name");
            entity.Property(e => e.PartnerType).HasColumnName("partner_type");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.SupplierRank).HasColumnName("supplier_rank");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<DimProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("dim_product_pkey");

            entity.ToTable("dim_product", "gold");

            entity.HasIndex(e => e.CategId, "idx_dim_product_category");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("product_id");
            entity.Property(e => e.CategId).HasColumnName("categ_id");
            entity.Property(e => e.CategName).HasColumnName("categ_name");
            entity.Property(e => e.CategoryFullName).HasColumnName("category_full_name");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.ProductCost).HasColumnName("product_cost");
            entity.Property(e => e.ProductGrossMarginEstimated).HasColumnName("product_gross_margin_estimated");
            entity.Property(e => e.ProductListPrice).HasColumnName("product_list_price");
            entity.Property(e => e.ProductName).HasColumnName("product_name");
            entity.Property(e => e.ProductSku).HasColumnName("product_sku");
            entity.Property(e => e.ProductStatus)
                .HasColumnType("character varying")
                .HasColumnName("product_status");
            entity.Property(e => e.ProductType)
                .HasColumnType("character varying")
                .HasColumnName("product_type");
            entity.Property(e => e.PurchaseOk).HasColumnName("purchase_ok");
            entity.Property(e => e.SaleOk).HasColumnName("sale_ok");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.Volume).HasColumnName("volume");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<DimProductCombo>(entity =>
        {
            entity.HasKey(e => e.ComboItemId).HasName("dim_product_combo_pkey");

            entity.ToTable("dim_product_combo", "gold");

            entity.Property(e => e.ComboItemId)
                .ValueGeneratedNever()
                .HasColumnName("combo_item_id");
            entity.Property(e => e.ComboId).HasColumnName("combo_id");
            entity.Property(e => e.ComboName).HasColumnName("combo_name");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.ExtraPrice).HasColumnName("extra_price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Product).WithMany(p => p.DimProductCombos)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_dim_product_combo_product");
        });

        modelBuilder.Entity<DimProductPricelist>(entity =>
        {
            entity.HasKey(e => e.PricelistItemId).HasName("dim_product_pricelist_pkey");

            entity.ToTable("dim_product_pricelist", "gold");

            entity.Property(e => e.PricelistItemId)
                .ValueGeneratedNever()
                .HasColumnName("pricelist_item_id");
            entity.Property(e => e.AppliedOn)
                .HasColumnType("character varying")
                .HasColumnName("applied_on");
            entity.Property(e => e.CategId).HasColumnName("categ_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.ComputePrice)
                .HasColumnType("character varying")
                .HasColumnName("compute_price");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.FixedPrice).HasColumnName("fixed_price");
            entity.Property(e => e.PercentPrice).HasColumnName("percent_price");
            entity.Property(e => e.PriceDiscount).HasColumnName("price_discount");
            entity.Property(e => e.PriceMarkup).HasColumnName("price_markup");
            entity.Property(e => e.PriceMaxMargin).HasColumnName("price_max_margin");
            entity.Property(e => e.PriceMinMargin).HasColumnName("price_min_margin");
            entity.Property(e => e.PriceSurcharge).HasColumnName("price_surcharge");
            entity.Property(e => e.PricelistId).HasColumnName("pricelist_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductTmplId).HasColumnName("product_tmpl_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("valid_from");
            entity.Property(e => e.ValidTo)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("valid_to");

            entity.HasOne(d => d.Product).WithMany(p => p.DimProductPricelists)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_dim_product_pricelist_product");
        });

        modelBuilder.Entity<DimStage>(entity =>
        {
            entity.HasKey(e => e.StageKey).HasName("dim_stage_pkey");

            entity.ToTable("dim_stage", "gold");

            entity.HasIndex(e => e.StageId, "dim_stage_stage_id_key").IsUnique();

            entity.HasIndex(e => e.StageId, "idx_dim_stage");

            entity.Property(e => e.StageKey).HasColumnName("stage_key");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.Probability).HasColumnName("probability");
            entity.Property(e => e.StageId).HasColumnName("stage_id");
            entity.Property(e => e.StageName).HasColumnName("stage_name");
        });

        modelBuilder.Entity<DimTeam>(entity =>
        {
            entity.HasKey(e => e.TeamKey).HasName("dim_team_pkey");

            entity.ToTable("dim_team", "gold");

            entity.HasIndex(e => e.TeamId, "dim_team_team_id_key").IsUnique();

            entity.Property(e => e.TeamKey).HasColumnName("team_key");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.TeamId).HasColumnName("team_id");
            entity.Property(e => e.TeamName).HasColumnName("team_name");
        });

        modelBuilder.Entity<DimWarehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("dim_warehouse_pkey");

            entity.ToTable("dim_warehouse", "gold");

            entity.Property(e => e.WarehouseId)
                .ValueGeneratedNever()
                .HasColumnName("warehouse_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DeliverySteps)
                .HasColumnType("character varying")
                .HasColumnName("delivery_steps");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.ReceptionSteps)
                .HasColumnType("character varying")
                .HasColumnName("reception_steps");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.WarehouseCode)
                .HasColumnType("character varying")
                .HasColumnName("warehouse_code");
            entity.Property(e => e.WarehouseName)
                .HasColumnType("character varying")
                .HasColumnName("warehouse_name");
        });

        modelBuilder.Entity<FactCrmPipeline>(entity =>
        {
            entity.HasKey(e => e.LeadKey).HasName("fact_crm_pipeline_pkey");

            entity.ToTable("fact_crm_pipeline", "gold");

            entity.HasIndex(e => new { e.CreatedDate, e.StageKey, e.CampaignKey }, "idx_crm_main");

            entity.HasIndex(e => new { e.IsWon, e.IsLost }, "idx_crm_status");

            entity.Property(e => e.LeadKey)
                .ValueGeneratedNever()
                .HasColumnName("lead_key");
            entity.Property(e => e.CampaignKey).HasColumnName("campaign_key");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.ExpectedRevenue).HasColumnName("expected_revenue");
            entity.Property(e => e.IsLost).HasColumnName("is_lost");
            entity.Property(e => e.IsWon).HasColumnName("is_won");
            entity.Property(e => e.LostReasonKey).HasColumnName("lost_reason_key");
            entity.Property(e => e.Probability).HasColumnName("probability");
            entity.Property(e => e.StageKey).HasColumnName("stage_key");
            entity.Property(e => e.TeamKey).HasColumnName("team_key");
            entity.Property(e => e.UpdatedDate).HasColumnName("updated_date");

            entity.HasOne(d => d.CampaignKeyNavigation).WithMany(p => p.FactCrmPipelines)
                .HasForeignKey(d => d.CampaignKey)
                .HasConstraintName("fk_crm_campaign");

            entity.HasOne(d => d.LeadKeyNavigation).WithOne(p => p.FactCrmPipeline)
                .HasForeignKey<FactCrmPipeline>(d => d.LeadKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_crm_lead");

            entity.HasOne(d => d.LostReasonKeyNavigation).WithMany(p => p.FactCrmPipelines)
                .HasForeignKey(d => d.LostReasonKey)
                .HasConstraintName("fk_crm_lost_reason");

            entity.HasOne(d => d.StageKeyNavigation).WithMany(p => p.FactCrmPipelines)
                .HasForeignKey(d => d.StageKey)
                .HasConstraintName("fk_crm_stage");

            entity.HasOne(d => d.TeamKeyNavigation).WithMany(p => p.FactCrmPipelines)
                .HasForeignKey(d => d.TeamKey)
                .HasConstraintName("fk_crm_team");
        });

        modelBuilder.Entity<FactEmployeeSnapshot>(entity =>
        {
            entity.HasKey(e => new { e.SnapshotDate, e.EmployeeKey }).HasName("fact_employee_snapshot_pkey");

            entity.ToTable("fact_employee_snapshot", "gold");

            entity.HasIndex(e => new { e.SnapshotDate, e.DepartmentKey, e.JobKey }, "idx_hr_snapshot_main");

            entity.Property(e => e.SnapshotDate).HasColumnName("snapshot_date");
            entity.Property(e => e.EmployeeKey).HasColumnName("employee_key");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DepartmentKey).HasColumnName("department_key");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.Headcount).HasColumnName("headcount");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.JobKey).HasColumnName("job_key");

            entity.HasOne(d => d.DepartmentKeyNavigation).WithMany(p => p.FactEmployeeSnapshots)
                .HasForeignKey(d => d.DepartmentKey)
                .HasConstraintName("fk_fact_hr_department");

            entity.HasOne(d => d.EmployeeKeyNavigation).WithMany(p => p.FactEmployeeSnapshots)
                .HasForeignKey(d => d.EmployeeKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fact_hr_employee");

            entity.HasOne(d => d.JobKeyNavigation).WithMany(p => p.FactEmployeeSnapshots)
                .HasForeignKey(d => d.JobKey)
                .HasConstraintName("fk_fact_hr_job");

            entity.HasOne(d => d.SnapshotDateNavigation).WithMany(p => p.FactEmployeeSnapshots)
                .HasForeignKey(d => d.SnapshotDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fact_hr_date");
        });

        modelBuilder.Entity<FactGlTransaction>(entity =>
        {
            entity.HasKey(e => e.MoveLineId).HasName("fact_gl_transactions_pkey");

            entity.ToTable("fact_gl_transactions", "gold");

            entity.Property(e => e.MoveLineId)
                .ValueGeneratedNever()
                .HasColumnName("move_line_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.JournalId).HasColumnName("journal_id");
            entity.Property(e => e.MoveDate).HasColumnName("move_date");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Account).WithMany(p => p.FactGlTransactions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_fact_gl_transactions_account");

            entity.HasOne(d => d.Company).WithMany(p => p.FactGlTransactions)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("fk_fact_gl_transactions_company");

            entity.HasOne(d => d.Journal).WithMany(p => p.FactGlTransactions)
                .HasForeignKey(d => d.JournalId)
                .HasConstraintName("fk_fact_gl_transactions_journal_dim");

            entity.HasOne(d => d.MoveDateNavigation).WithMany(p => p.FactGlTransactions)
                .HasForeignKey(d => d.MoveDate)
                .HasConstraintName("fk_fact_gl_transactions_move_date");

            entity.HasOne(d => d.Partner).WithMany(p => p.FactGlTransactions)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("fk_fact_gl_transactions_partner");

            entity.HasOne(d => d.Product).WithMany(p => p.FactGlTransactions)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_fact_gl_transactions_product");
        });

        modelBuilder.Entity<FactInventoryMovement>(entity =>
        {
            entity.HasKey(e => e.StockMoveLineId).HasName("fact_inventory_movement_pkey");

            entity.ToTable("fact_inventory_movement", "gold");

            entity.HasIndex(e => new { e.FromLocationId, e.ToLocationId }, "idx_inventory_movement_locations");

            entity.HasIndex(e => new { e.MovementDate, e.ProductId }, "idx_inventory_movement_main");

            entity.Property(e => e.StockMoveLineId)
                .ValueGeneratedNever()
                .HasColumnName("stock_move_line_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.FromLocationId).HasColumnName("from_location_id");
            entity.Property(e => e.IsIn).HasColumnName("is_in");
            entity.Property(e => e.IsInternal).HasColumnName("is_internal");
            entity.Property(e => e.IsOut).HasColumnName("is_out");
            entity.Property(e => e.LotId).HasColumnName("lot_id");
            entity.Property(e => e.LotName).HasColumnName("lot_name");
            entity.Property(e => e.MoveState).HasColumnName("move_state");
            entity.Property(e => e.MoveValue).HasColumnName("move_value");
            entity.Property(e => e.MovementDate).HasColumnName("movement_date");
            entity.Property(e => e.PickingId).HasColumnName("picking_id");
            entity.Property(e => e.PickingName).HasColumnName("picking_name");
            entity.Property(e => e.PickingState).HasColumnName("picking_state");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ToLocationId).HasColumnName("to_location_id");
            entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.FactInventoryMovementFromLocations)
                .HasForeignKey(d => d.FromLocationId)
                .HasConstraintName("fk_fact_inventory_movement_from_location");

            entity.HasOne(d => d.MovementDateNavigation).WithMany(p => p.FactInventoryMovements)
                .HasForeignKey(d => d.MovementDate)
                .HasConstraintName("fk_fact_inventory_movement_movement_date");

            entity.HasOne(d => d.Product).WithMany(p => p.FactInventoryMovements)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_fact_inventory_movement_product");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.FactInventoryMovementToLocations)
                .HasForeignKey(d => d.ToLocationId)
                .HasConstraintName("fk_fact_inventory_movement_to_location");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.FactInventoryMovements)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("fk_fact_inventory_movement_warehouse");
        });

        modelBuilder.Entity<FactInventorySnapshot>(entity =>
        {
            entity.HasKey(e => e.StockQuantId).HasName("fact_inventory_snapshot_pkey");

            entity.ToTable("fact_inventory_snapshot", "gold");

            entity.HasIndex(e => new { e.InventoryDate, e.ProductId, e.WarehouseId }, "idx_inventory_snapshot_main");

            entity.Property(e => e.StockQuantId)
                .ValueGeneratedNever()
                .HasColumnName("stock_quant_id");
            entity.Property(e => e.AvailableQuantity).HasColumnName("available_quantity");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.InventoryDate).HasColumnName("inventory_date");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ReservedQuantity).HasColumnName("reserved_quantity");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.InventoryDateNavigation).WithMany(p => p.FactInventorySnapshots)
                .HasForeignKey(d => d.InventoryDate)
                .HasConstraintName("fk_fact_inventory_snapshot_date");

            entity.HasOne(d => d.Location).WithMany(p => p.FactInventorySnapshots)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("fk_fact_inventory_snapshot_location");

            entity.HasOne(d => d.Product).WithMany(p => p.FactInventorySnapshots)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_fact_inventory_snapshot_product");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.FactInventorySnapshots)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("fk_fact_inventory_snapshot_warehouse_dim");
        });

        modelBuilder.Entity<FactInvoice>(entity =>
        {
            entity.HasKey(e => e.MoveId).HasName("fact_invoice_pkey");

            entity.ToTable("fact_invoice", "gold");

            entity.Property(e => e.MoveId)
                .ValueGeneratedNever()
                .HasColumnName("move_id");
            entity.Property(e => e.AmountResidual).HasColumnName("amount_residual");
            entity.Property(e => e.AmountTax).HasColumnName("amount_tax");
            entity.Property(e => e.AmountTotal).HasColumnName("amount_total");
            entity.Property(e => e.AmountUntaxed).HasColumnName("amount_untaxed");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DueDate).HasColumnName("due_date");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.InvoiceDate).HasColumnName("invoice_date");
            entity.Property(e => e.InvoiceStatus)
                .HasColumnType("character varying")
                .HasColumnName("invoice_status");
            entity.Property(e => e.JournalId).HasColumnName("journal_id");
            entity.Property(e => e.MoveDate).HasColumnName("move_date");
            entity.Property(e => e.MoveType)
                .HasColumnType("character varying")
                .HasColumnName("move_type");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.PaymentState)
                .HasColumnType("character varying")
                .HasColumnName("payment_state");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");

            entity.HasOne(d => d.Company).WithMany(p => p.FactInvoices)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("fk_fact_invoice_company");

            entity.HasOne(d => d.DueDateNavigation).WithMany(p => p.FactInvoiceDueDateNavigations)
                .HasForeignKey(d => d.DueDate)
                .HasConstraintName("fk_fact_invoice_due_date");

            entity.HasOne(d => d.InvoiceDateNavigation).WithMany(p => p.FactInvoiceInvoiceDateNavigations)
                .HasForeignKey(d => d.InvoiceDate)
                .HasConstraintName("fk_fact_invoice_invoice_date");

            entity.HasOne(d => d.Journal).WithMany(p => p.FactInvoices)
                .HasForeignKey(d => d.JournalId)
                .HasConstraintName("fk_fact_invoice_journal_dim");

            entity.HasOne(d => d.MoveDateNavigation).WithMany(p => p.FactInvoiceMoveDateNavigations)
                .HasForeignKey(d => d.MoveDate)
                .HasConstraintName("fk_fact_invoice_move_date");

            entity.HasOne(d => d.Partner).WithMany(p => p.FactInvoices)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("fk_fact_invoice_partner");
        });

        modelBuilder.Entity<FactPurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderLineId).HasName("fact_purchase_order_pkey");

            entity.ToTable("fact_purchase_order", "gold");

            entity.HasIndex(e => e.CompanyId, "idx_fact_purchase_company");

            entity.HasIndex(e => new { e.OrderDate, e.ProductId, e.SupplierId }, "idx_fact_purchase_main");

            entity.Property(e => e.PurchaseOrderLineId)
                .ValueGeneratedNever()
                .HasColumnName("purchase_order_line_id");
            entity.Property(e => e.AmountTax).HasColumnName("amount_tax");
            entity.Property(e => e.AmountTotal).HasColumnName("amount_total");
            entity.Property(e => e.AmountUntaxed).HasColumnName("amount_untaxed");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DateApprove).HasColumnName("date_approve");
            entity.Property(e => e.DatePlanned).HasColumnName("date_planned");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.InvoiceStatus)
                .HasColumnType("character varying")
                .HasColumnName("invoice_status");
            entity.Property(e => e.LineDescription).HasColumnName("line_description");
            entity.Property(e => e.OrderCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("order_created_at");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderState)
                .HasColumnType("character varying")
                .HasColumnName("order_state");
            entity.Property(e => e.OrderUpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("order_updated_at");
            entity.Property(e => e.OrderUserId).HasColumnName("order_user_id");
            entity.Property(e => e.PickingTypeId).HasColumnName("picking_type_id");
            entity.Property(e => e.PriceSubtotal).HasColumnName("price_subtotal");
            entity.Property(e => e.PriceTotal).HasColumnName("price_total");
            entity.Property(e => e.PriceUnit).HasColumnName("price_unit");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductQty).HasColumnName("product_qty");
            entity.Property(e => e.ProductUomId).HasColumnName("product_uom_id");
            entity.Property(e => e.ProductUomQty).HasColumnName("product_uom_qty");
            entity.Property(e => e.PurchaseOrderId).HasColumnName("purchase_order_id");
            entity.Property(e => e.QtyInvoiced).HasColumnName("qty_invoiced");
            entity.Property(e => e.QtyReceived).HasColumnName("qty_received");
            entity.Property(e => e.QtyToInvoice).HasColumnName("qty_to_invoice");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

            entity.HasOne(d => d.Company).WithMany(p => p.FactPurchaseOrders)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("fk_fact_purchase_order_company");

            entity.HasOne(d => d.DateApproveNavigation).WithMany(p => p.FactPurchaseOrderDateApproveNavigations)
                .HasForeignKey(d => d.DateApprove)
                .HasConstraintName("fk_fact_purchase_order_date_approve");

            entity.HasOne(d => d.DatePlannedNavigation).WithMany(p => p.FactPurchaseOrderDatePlannedNavigations)
                .HasForeignKey(d => d.DatePlanned)
                .HasConstraintName("fk_fact_purchase_order_date_planned");

            entity.HasOne(d => d.OrderDateNavigation).WithMany(p => p.FactPurchaseOrderOrderDateNavigations)
                .HasForeignKey(d => d.OrderDate)
                .HasConstraintName("fk_fact_purchase_order_order_date");

            entity.HasOne(d => d.Product).WithMany(p => p.FactPurchaseOrders)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_fact_purchase_product");

            entity.HasOne(d => d.Supplier).WithMany(p => p.FactPurchaseOrders)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("fk_fact_purchase_order_supplier");
        });

        modelBuilder.Entity<FactSale>(entity =>
        {
            entity.HasKey(e => e.SaleOrderLineId).HasName("fact_sales_pkey");

            entity.ToTable("fact_sales", "gold");

            entity.HasIndex(e => new { e.OrderDate, e.ProductId, e.CustomerId }, "idx_fact_sales_main");

            entity.HasIndex(e => e.OrderId, "idx_fact_sales_order_id");

            entity.Property(e => e.SaleOrderLineId)
                .ValueGeneratedNever()
                .HasColumnName("sale_order_line_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.DwhLoadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dwh_loaded_at");
            entity.Property(e => e.GrossRevenue).HasColumnName("gross_revenue");
            entity.Property(e => e.InvoiceStatus)
                .HasColumnType("character varying")
                .HasColumnName("invoice_status");
            entity.Property(e => e.NetRevenue).HasColumnName("net_revenue");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.OrderState)
                .HasColumnType("character varying")
                .HasColumnName("order_state");
            entity.Property(e => e.PriceSubtotal).HasColumnName("price_subtotal");
            entity.Property(e => e.PriceTax).HasColumnName("price_tax");
            entity.Property(e => e.PriceTotal).HasColumnName("price_total");
            entity.Property(e => e.PriceUnit).HasColumnName("price_unit");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductQty).HasColumnName("product_qty");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Customer).WithMany(p => p.FactSales)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fk_fact_sales_customer");

            entity.HasOne(d => d.OrderDateNavigation).WithMany(p => p.FactSales)
                .HasForeignKey(d => d.OrderDate)
                .HasConstraintName("fk_fact_sales_order_date");

            entity.HasOne(d => d.Product).WithMany(p => p.FactSales)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_fact_sales_product");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
