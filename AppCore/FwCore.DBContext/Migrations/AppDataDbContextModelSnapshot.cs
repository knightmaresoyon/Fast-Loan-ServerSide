﻿// <auto-generated />
using System;
using FwCore.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FwCore.DBContext.Migrations
{
    [DbContext(typeof(AppDataDbContext))]
    partial class AppDataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FwCore.DBContext.Model.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.Granter", b =>
                {
                    b.Property<int>("GranterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FatherName")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("MotherName")
                        .IsRequired();

                    b.Property<string>("Nationality")
                        .IsRequired();

                    b.Property<string>("Occupation")
                        .IsRequired();

                    b.Property<string>("PermanentAddress")
                        .IsRequired();

                    b.Property<string>("PresentAddress")
                        .IsRequired();

                    b.Property<string>("Relation")
                        .IsRequired();

                    b.Property<string>("Religion")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<int?>("VerificationSourceId");

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("GranterId");

                    b.HasIndex("VerificationSourceId");

                    b.ToTable("Granters");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApprovedBy");

                    b.Property<int?>("DocumentId");

                    b.Property<int?>("GranterId");

                    b.Property<DateTime>("IssueDate");

                    b.Property<int?>("LoanTypeId");

                    b.Property<string>("OperateBy");

                    b.Property<int?>("StatusId");

                    b.Property<int?>("UserId");

                    b.HasKey("LoanId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("GranterId");

                    b.HasIndex("LoanTypeId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.LoanApplication", b =>
                {
                    b.Property<int>("LoanApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GranterCity")
                        .IsRequired();

                    b.Property<string>("GranterCountry")
                        .IsRequired();

                    b.Property<DateTime>("GranterDateOfBirth");

                    b.Property<string>("GranterEmailAddress")
                        .IsRequired();

                    b.Property<string>("GranterFatherName")
                        .IsRequired();

                    b.Property<string>("GranterFirstName")
                        .IsRequired();

                    b.Property<string>("GranterGender")
                        .IsRequired();

                    b.Property<string>("GranterLastName")
                        .IsRequired();

                    b.Property<string>("GranterMobile")
                        .IsRequired();

                    b.Property<string>("GranterMotherName")
                        .IsRequired();

                    b.Property<string>("GranterNationality")
                        .IsRequired();

                    b.Property<string>("GranterOccupation")
                        .IsRequired();

                    b.Property<string>("GranterPermanentAddress")
                        .IsRequired();

                    b.Property<string>("GranterPresentAddress")
                        .IsRequired();

                    b.Property<string>("GranterRelation")
                        .IsRequired();

                    b.Property<string>("GranterReligion")
                        .IsRequired();

                    b.Property<string>("GranterState")
                        .IsRequired();

                    b.Property<string>("GranterVerificationCode")
                        .IsRequired();

                    b.Property<string>("GranterVerificationType")
                        .IsRequired();

                    b.Property<string>("GranterZipCode")
                        .IsRequired();

                    b.Property<int>("Installments");

                    b.Property<double>("LoanAmount");

                    b.Property<string>("LoanType")
                        .IsRequired();

                    b.Property<string>("UserCity")
                        .IsRequired();

                    b.Property<string>("UserCountry")
                        .IsRequired();

                    b.Property<DateTime>("UserDateOfBirth");

                    b.Property<string>("UserEmailAddress")
                        .IsRequired();

                    b.Property<string>("UserFatherName")
                        .IsRequired();

                    b.Property<string>("UserFirstName")
                        .IsRequired();

                    b.Property<string>("UserGender")
                        .IsRequired();

                    b.Property<string>("UserLastName")
                        .IsRequired();

                    b.Property<string>("UserMobile")
                        .IsRequired();

                    b.Property<string>("UserMotherName")
                        .IsRequired();

                    b.Property<string>("UserNationality")
                        .IsRequired();

                    b.Property<string>("UserOccupation")
                        .IsRequired();

                    b.Property<string>("UserPermanentAddress")
                        .IsRequired();

                    b.Property<string>("UserPresentAddress")
                        .IsRequired();

                    b.Property<string>("UserReligion")
                        .IsRequired();

                    b.Property<string>("UserState")
                        .IsRequired();

                    b.Property<string>("UserVerificationCode")
                        .IsRequired();

                    b.Property<string>("UserVerificationType")
                        .IsRequired();

                    b.Property<string>("UserZipCode")
                        .IsRequired();

                    b.HasKey("LoanApplicationId");

                    b.ToTable("LoanApplications");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.LoanInstallment", b =>
                {
                    b.Property<int>("LoanInstallmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActualPayDate");

                    b.Property<double>("EMI");

                    b.Property<int?>("LoanId");

                    b.Property<double>("PayAmount");

                    b.Property<double>("Penalty");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("ScheduleDate");

                    b.HasKey("LoanInstallmentId");

                    b.HasIndex("LoanId");

                    b.ToTable("LoanInstallments");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.LoanType", b =>
                {
                    b.Property<int>("LoanTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("InterestRate");

                    b.Property<double>("LoanAmount");

                    b.Property<string>("LoanTypeName");

                    b.Property<int>("NoOfInstallment");

                    b.HasKey("LoanTypeId");

                    b.ToTable("LoanTypes");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoanStatus");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FatherName")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("MotherName")
                        .IsRequired();

                    b.Property<string>("Nationality")
                        .IsRequired();

                    b.Property<string>("Occupation")
                        .IsRequired();

                    b.Property<string>("PermanentAddress")
                        .IsRequired();

                    b.Property<string>("PresentAddress")
                        .IsRequired();

                    b.Property<string>("Religion")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("UserType");

                    b.Property<int?>("VerificationSourceId");

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("VerificationSourceId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.VerificationSource", b =>
                {
                    b.Property<int>("VerificationSourceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VerificationCode");

                    b.Property<string>("VerificationType");

                    b.HasKey("VerificationSourceId");

                    b.ToTable("VerificationSources");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.Granter", b =>
                {
                    b.HasOne("FwCore.DBContext.Model.VerificationSource", "Verification")
                        .WithMany()
                        .HasForeignKey("VerificationSourceId");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.Loan", b =>
                {
                    b.HasOne("FwCore.DBContext.Model.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId");

                    b.HasOne("FwCore.DBContext.Model.Granter", "Granter")
                        .WithMany()
                        .HasForeignKey("GranterId");

                    b.HasOne("FwCore.DBContext.Model.LoanType", "LoanType")
                        .WithMany()
                        .HasForeignKey("LoanTypeId");

                    b.HasOne("FwCore.DBContext.Model.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("FwCore.DBContext.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.LoanInstallment", b =>
                {
                    b.HasOne("FwCore.DBContext.Model.Loan")
                        .WithMany("LoanInstallments")
                        .HasForeignKey("LoanId");
                });

            modelBuilder.Entity("FwCore.DBContext.Model.User", b =>
                {
                    b.HasOne("FwCore.DBContext.Model.VerificationSource", "Verification")
                        .WithMany()
                        .HasForeignKey("VerificationSourceId");
                });
#pragma warning restore 612, 618
        }
    }
}
