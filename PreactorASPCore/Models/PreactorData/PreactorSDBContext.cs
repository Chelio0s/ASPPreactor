using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PreactorASPCore.Models.PreactorData
{
    public partial class PreactorSDBContext : DbContext
    {
        public PreactorSDBContext()
        {
        }

        public PreactorSDBContext(DbContextOptions<PreactorSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AltOperationRule> AltOperationRule { get; set; }
        public virtual DbSet<AltOperations> AltOperations { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<BalanceOmts> BalanceOmts { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Cicle> Cicle { get; set; }
        public virtual DbSet<DepartComposition> DepartComposition { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeesCalendar> EmployeesCalendar { get; set; }
        public virtual DbSet<EmployeesInProfession> EmployeesInProfession { get; set; }
        public virtual DbSet<EntrySemiProduct> EntrySemiProduct { get; set; }
        public virtual DbSet<EntrySimpleProduct> EntrySimpleProduct { get; set; }
        public virtual DbSet<GroupKob> GroupKob { get; set; }
        public virtual DbSet<GroupKtop> GroupKtop { get; set; }
        public virtual DbSet<GroupsOperations> GroupsOperations { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Nomenclature> Nomenclature { get; set; }
        public virtual DbSet<OperationInResource> OperationInResource { get; set; }
        public virtual DbSet<Operations> Operations { get; set; }
        public virtual DbSet<Orgunit> Orgunit { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Professions> Professions { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<ResourcesGroup> ResourcesGroup { get; set; }
        public virtual DbSet<ResourcesInGroups> ResourcesInGroups { get; set; }
        public virtual DbSet<SecondaryConstraints> SecondaryConstraints { get; set; }
        public virtual DbSet<SemiProducts> SemiProducts { get; set; }
        public virtual DbSet<SequenceOperations> SequenceOperations { get; set; }
        public virtual DbSet<SettingShift> SettingShift { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<SimpleProduct> SimpleProduct { get; set; }
        public virtual DbSet<Specifications> Specifications { get; set; }
        public virtual DbSet<SupplyOmts> SupplyOmts { get; set; }
        public virtual DbSet<UseConstraintOperations> UseConstraintOperations { get; set; }
        public virtual DbSet<UseConstraintResources> UseConstraintResources { get; set; }
        public virtual DbSet<WorkDays> WorkDays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.30.6.11;Database=PreactorSDB;User ID = MPU; password = 12345a;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AltOperationRule>(entity =>
            {
                entity.HasKey(e => e.IdRule);

                entity.ToTable("AltOperationRule", "SupportData");

                entity.HasIndex(e => new { e.AltOperationId, e.Ktop })
                    .HasName("UK_AltOperationRule_Column")
                    .IsUnique();

                entity.Property(e => e.Ktop).HasColumnName("KTOP");

                entity.HasOne(d => d.AltOperation)
                    .WithMany(p => p.AltOperationRule)
                    .HasForeignKey(d => d.AltOperationId)
                    .HasConstraintName("FK_AltOperationRule_ToAltOperation");
            });

            modelBuilder.Entity<AltOperations>(entity =>
            {
                entity.HasKey(e => e.IdKtop);

                entity.ToTable("AltOperations", "SupportData");

                entity.Property(e => e.IdKtop).ValueGeneratedNever();

                entity.Property(e => e.Ktop).HasColumnName("KTOP");
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.ToTable("Areas", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Areas__2CB664DC2BE892E7")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle);

                entity.ToTable("Article", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Article__2CB664DCC82141A4")
                    .IsUnique();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<BalanceOmts>(entity =>
            {
                entity.HasKey(e => e.IdBalance);

                entity.ToTable("BalanceOMTS", "InputData");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.BalanceOmts)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BalanceOMTS_ToTable");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.IdCalendar);

                entity.ToTable("Calendar", "InputData");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.SecondaryConstraint)
                    .WithMany(p => p.Calendar)
                    .HasForeignKey(d => d.SecondaryConstraintId)
                    .HasConstraintName("FK_Calendar_ToSecondaryConstraint");
            });

            modelBuilder.Entity<Cicle>(entity =>
            {
                entity.HasKey(e => e.IdCicle);

                entity.ToTable("Cicle", "SupportData");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Cicle)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_Cicle_ToOrguinut");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Cicle)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cicle_ToShift");
            });

            modelBuilder.Entity<DepartComposition>(entity =>
            {
                entity.HasKey(e => e.IdDepComposition);

                entity.ToTable("DepartComposition", "SupportData");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartComposition)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartComposition_ToDepartments");

                entity.HasOne(d => d.ResourcesGroup)
                    .WithMany(p => p.DepartComposition)
                    .HasForeignKey(d => d.ResourcesGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartComposition_ToResourcesGroup");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.IdDepartment);

                entity.ToTable("Departments", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__tmp_ms_x__2CB664DCE052A13C")
                    .IsUnique();

                entity.Property(e => e.IdDepartment).ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departments_ToAreas");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.TabNum);

                entity.ToTable("Employees", "InputData");

                entity.HasIndex(e => e.TabNum)
                    .HasName("UQ__Employee__A669FD04BA4A70AF")
                    .IsUnique();

                entity.Property(e => e.TabNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.OrgunitNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Orgunit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_ToOrgunit");
            });

            modelBuilder.Entity<EmployeesCalendar>(entity =>
            {
                entity.HasKey(e => e.IdEmpCalendar);

                entity.ToTable("EmployeesCalendar", "InputData");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.OrgUnitNavigation)
                    .WithMany(p => p.EmployeesCalendar)
                    .HasForeignKey(d => d.OrgUnit)
                    .HasConstraintName("FK_EmployeesCalendar_ToEmployees");
            });

            modelBuilder.Entity<EmployeesInProfession>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.ProfessionId, e.CategoryProfession });

                entity.ToTable("EmployeesInProfession", "InputData");

                entity.HasIndex(e => new { e.EmployeeId, e.IsPrimary })
                    .HasName("UK_EmployeesInProfession_EmpID_IsPrimary");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeesInProfession)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeesInProfession_ToEmployee");

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.EmployeesInProfession)
                    .HasForeignKey(d => d.ProfessionId)
                    .HasConstraintName("FK_EmployeesInProfession_ToProfession");
            });

            modelBuilder.Entity<EntrySemiProduct>(entity =>
            {
                entity.HasKey(e => new { e.IdSemiProduct, e.IdSemiProductChild });

                entity.ToTable("EntrySemiProduct", "InputData");

                entity.HasOne(d => d.IdSemiProductNavigation)
                    .WithMany(p => p.EntrySemiProductIdSemiProductNavigation)
                    .HasForeignKey(d => d.IdSemiProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrySemiProduct_ToSemiProduct");

                entity.HasOne(d => d.IdSemiProductChildNavigation)
                    .WithMany(p => p.EntrySemiProductIdSemiProductChildNavigation)
                    .HasForeignKey(d => d.IdSemiProductChild)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrySemiProduct_ToSemiProductEntry");
            });

            modelBuilder.Entity<EntrySimpleProduct>(entity =>
            {
                entity.HasKey(e => new { e.SimpleProductId, e.SimpleProductIdChild });

                entity.ToTable("EntrySimpleProduct", "SupportData");

                entity.HasOne(d => d.SimpleProduct)
                    .WithMany(p => p.EntrySimpleProductSimpleProduct)
                    .HasForeignKey(d => d.SimpleProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrySimpleProduct_ToSimpleProduct1");

                entity.HasOne(d => d.SimpleProductIdChildNavigation)
                    .WithMany(p => p.EntrySimpleProductSimpleProductIdChildNavigation)
                    .HasForeignKey(d => d.SimpleProductIdChild)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntrySimpleProduct_ToSimpleProduct2");
            });

            modelBuilder.Entity<GroupKob>(entity =>
            {
                entity.HasKey(e => e.IdGroupKob);

                entity.ToTable("GroupKOB", "SupportData");

                entity.HasIndex(e => new { e.Kob, e.Ktopn, e.AreaId })
                    .HasName("UK_GroupKOB_KOB_KTOPN_AreaId")
                    .IsUnique();

                entity.Property(e => e.IdGroupKob).HasColumnName("IdGroupKOB");

                entity.Property(e => e.Kob).HasColumnName("KOB");

                entity.Property(e => e.Ktopn).HasColumnName("KTOPN");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.GroupKob)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GroupKOB_ToArea");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupKob)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupKOB_ToGroups");
            });

            modelBuilder.Entity<GroupKtop>(entity =>
            {
                entity.HasKey(e => e.IdGroupKtop);

                entity.ToTable("GroupKTOP", "SupportData");

                entity.Property(e => e.IdGroupKtop).HasColumnName("IdGroupKTOP");

                entity.Property(e => e.Ktop).HasColumnName("KTOP");

                entity.HasOne(d => d.GroupOperation)
                    .WithMany(p => p.GroupKtop)
                    .HasForeignKey(d => d.GroupOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupKTOP_ToGroupsOperations");
            });

            modelBuilder.Entity<GroupsOperations>(entity =>
            {
                entity.HasKey(e => e.IdGroupOperations);

                entity.ToTable("GroupsOperations", "SupportData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__tmp_ms_x__2CB664DC591D692E")
                    .IsUnique();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log", "LogData");

                entity.Property(e => e.EventSqlcommand)
                    .HasColumnName("EventSQLCommand")
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("IP_address")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Xmlchange)
                    .HasColumnName("XMLChange")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.IdMaterial);

                entity.ToTable("Material", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Material__2CB664DC8512B612")
                    .IsUnique();

                entity.Property(e => e.Attribute)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<Nomenclature>(entity =>
            {
                entity.HasKey(e => e.IdNomenclature);

                entity.ToTable("Nomenclature", "InputData");

                entity.HasIndex(e => e.Number)
                    .HasName("UQ__Nomencla__47C825FB0A4F59C9")
                    .IsUnique();

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("Number_")
                    .HasMaxLength(99);

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Nomenclature)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_Nomenclature_ToArticle");
            });

            modelBuilder.Entity<OperationInResource>(entity =>
            {
                entity.HasKey(e => e.IdOpInResource);

                entity.ToTable("OperationInResource", "InputData");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.OperationInResource)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_OperationInResource_ToOperations");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.OperationInResource)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperationInResource_ToResource");
            });

            modelBuilder.Entity<Operations>(entity =>
            {
                entity.HasKey(e => e.IdOperation);

                entity.ToTable("Operations", "InputData");

                entity.Property(e => e.SemiProductId).HasColumnName("SemiProductID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.ProfessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operations_ToProfGroup");

                entity.HasOne(d => d.SemiProduct)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.SemiProductId)
                    .HasConstraintName("FK_Operations_ToSemiProduct");
            });

            modelBuilder.Entity<Orgunit>(entity =>
            {
                entity.HasKey(e => e.OrgUnit1);

                entity.ToTable("Orgunit", "SupportData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__tmp_ms_x__2CB664DCACC3BCE6")
                    .IsUnique();

                entity.Property(e => e.OrgUnit1)
                    .HasColumnName("OrgUnit")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crew).HasMaxLength(1);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Orgunit)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Orgunit_ToArea");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.ToTable("Plan", "InputData");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_Plan_ToArticle");
            });

            modelBuilder.Entity<Professions>(entity =>
            {
                entity.HasKey(e => e.IdProfession);

                entity.ToTable("Professions", "InputData");

                entity.Property(e => e.IdProfession).ValueGeneratedNever();

                entity.Property(e => e.CodeRkv)
                    .IsRequired()
                    .HasColumnName("CodeRKV")
                    .HasMaxLength(99);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.HasKey(e => e.IdResource);

                entity.ToTable("Resources", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__tmp_ms_x__2CB664DC534FE398")
                    .IsUnique();

                entity.Property(e => e.IdResource).ValueGeneratedNever();

                entity.Property(e => e.Kob).HasColumnName("KOB");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.Property(e => e.TitleWorkPlace)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Resources_ToDepartment");
            });

            modelBuilder.Entity<ResourcesGroup>(entity =>
            {
                entity.HasKey(e => e.IdResourceGroup);

                entity.ToTable("ResourcesGroup", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Resource__2CB664DC98D40858")
                    .IsUnique();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<ResourcesInGroups>(entity =>
            {
                entity.HasKey(e => new { e.ResourceId, e.GroupResourcesId });

                entity.ToTable("ResourcesInGroups", "InputData");

                entity.HasOne(d => d.GroupResources)
                    .WithMany(p => p.ResourcesInGroups)
                    .HasForeignKey(d => d.GroupResourcesId)
                    .HasConstraintName("FK_ResourcesInGroups_ToGroups");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourcesInGroups)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_ResourcesInGroups_ToResources");
            });

            modelBuilder.Entity<SecondaryConstraints>(entity =>
            {
                entity.HasKey(e => e.IdSecondaryConstraint);

                entity.ToTable("SecondaryConstraints", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Secondar__2CB664DCAEE1EC79")
                    .IsUnique();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<SemiProducts>(entity =>
            {
                entity.HasKey(e => e.IdSemiProduct);

                entity.ToTable("SemiProducts", "InputData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__SemiProd__2CB664DCBB60B5B1")
                    .IsUnique();

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.SemiProducts)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_SemiProducts_ToNomenclature");
            });

            modelBuilder.Entity<SequenceOperations>(entity =>
            {
                entity.HasKey(e => e.IdSeqOperation);

                entity.ToTable("SequenceOperations", "SupportData");

                entity.Property(e => e.Ktop).HasColumnName("KTOP");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);

                entity.HasOne(d => d.SimpleProduct)
                    .WithMany(p => p.SequenceOperations)
                    .HasForeignKey(d => d.SimpleProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SequenceOperations_ToSimpleProduct");
            });

            modelBuilder.Entity<SettingShift>(entity =>
            {
                entity.HasKey(e => e.IdSettingShift);

                entity.ToTable("SettingShift", "SupportData");

                entity.HasIndex(e => new { e.AreaId, e.ShiftId, e.TimeStart })
                    .HasName("UK_SettingShift_Org_Shift_Time")
                    .IsUnique();

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.SettingShift)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_SettingShift_ToOrgunit");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.SettingShift)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettingShift_ToShift");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.IdShift);

                entity.ToTable("Shift", "SupportData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Shift__2CB664DC65D56994")
                    .IsUnique();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SimpleProduct>(entity =>
            {
                entity.HasKey(e => e.IdSimpleProduct);

                entity.ToTable("SimpleProduct", "SupportData");

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__tmp_ms_x__2CB664DCDDDEDB24")
                    .IsUnique();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(99);
            });

            modelBuilder.Entity<Specifications>(entity =>
            {
                entity.HasKey(e => e.IdSpecification);

                entity.ToTable("Specifications", "InputData");

                entity.HasIndex(e => e.IdSpecification)
                    .HasName("UQ__Specific__9F144EC5C49D2DF6")
                    .IsUnique();

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Specifications)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specifications_ToMaterial");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.Specifications)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specifications_ToOperation");
            });

            modelBuilder.Entity<SupplyOmts>(entity =>
            {
                entity.HasKey(e => e.IdSupply);

                entity.ToTable("SupplyOMTS", "InputData");

                entity.HasIndex(e => e.SupplyOrder)
                    .HasName("UQ__SupplyOM__392CDD27A181C606")
                    .IsUnique();

                entity.Property(e => e.DateSupply).HasColumnType("datetime");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SupplyOmts)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyOMTS_ToMaterial");
            });

            modelBuilder.Entity<UseConstraintOperations>(entity =>
            {
                entity.HasKey(e => e.IdUseConstraint);

                entity.ToTable("UseConstraintOperations", "InputData");

                entity.HasOne(d => d.Constraint)
                    .WithMany(p => p.UseConstraintOperations)
                    .HasForeignKey(d => d.ConstraintId)
                    .HasConstraintName("FK_UseConstraint_ToConstraint_Oper");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.UseConstraintOperations)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseConstraint_ToResources_Oper");
            });

            modelBuilder.Entity<UseConstraintResources>(entity =>
            {
                entity.HasKey(e => e.IdUseConstraint);

                entity.ToTable("UseConstraintResources", "InputData");

                entity.HasOne(d => d.Constraint)
                    .WithMany(p => p.UseConstraintResources)
                    .HasForeignKey(d => d.ConstraintId)
                    .HasConstraintName("FK_UseConstraint_ToConstraint");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.UseConstraintResources)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseConstraint_ToResources");
            });

            modelBuilder.Entity<WorkDays>(entity =>
            {
                entity.HasKey(e => e.IdWorkDay);

                entity.ToTable("WorkDays", "SupportData");

                entity.HasIndex(e => new { e.DateWorkDay, e.ShiftId, e.Crew })
                    .HasName("UK_WorkDays_DayShiftCrew")
                    .IsUnique();

                entity.Property(e => e.Crew)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DateWorkDay).HasColumnType("date");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.WorkDays)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkDays_ToShift");
            });
        }
    }
}
