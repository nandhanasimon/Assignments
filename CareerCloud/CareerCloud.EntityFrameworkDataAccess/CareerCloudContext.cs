using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        protected string _connectionString;
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistorys { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            string _connectionString = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEducationPoco>()
                     .HasOne(e => e.ApplicantProfile)
                     .WithMany(e => e.ApplicantEducations)
                     .HasForeignKey(e => e.Applicant);

            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                   .HasOne(e => e.ApplicantProfile)
                   .WithMany(e => e.ApplicantJobApplications)
                   .HasForeignKey(e => e.Applicant);

            modelBuilder.Entity<ApplicantJobApplicationPoco>()
                    .HasOne(e => e.CompanyJob)
                    .WithMany(e => e.ApplicationJobApplications)
                    .HasForeignKey(e => e.Job);

            modelBuilder.Entity<ApplicantProfilePoco>()
                    .HasOne(e => e.SecurityLogin)
                    .WithMany(e => e.ApplicantProfiles)
                    .HasForeignKey(e => e.Login);


            modelBuilder.Entity<ApplicantProfilePoco>()
                    .HasOne(e => e.SystemCountryCode)
                    .WithMany(e => e.ApplicantProfiles)
                    .HasForeignKey(e => e.Country);


            modelBuilder.Entity<ApplicantResumePoco>()
                    .HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantResumes)
                    .HasForeignKey(e => e.Applicant);


            modelBuilder.Entity<ApplicantSkillPoco>()
                    .HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantSkills)
                    .HasForeignKey(e => e.Applicant);

            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                    .HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantWorkHistorys)
                    .HasForeignKey(e => e.Applicant);

            modelBuilder.Entity<ApplicantWorkHistoryPoco>()
                    .HasOne(e => e.SystemCountryCode)
                    .WithMany(e => e.ApplicantWorkHistorys)
                    .HasForeignKey(e => e.CountryCode);

            modelBuilder.Entity<CompanyDescriptionPoco>()
                    .HasOne(e => e.SystemLanguageCode)
                    .WithMany(e => e.CompanyDescriptions)
                    .HasForeignKey(e => e.LanguageId);

            modelBuilder.Entity<CompanyDescriptionPoco>()
                    .HasOne(e => e.CompanyProfile)
                    .WithMany(e => e.CompanyDescriptions)
                    .HasForeignKey(e => e.Company);

            modelBuilder.Entity<CompanyJobDescriptionPoco>()
                    .HasOne(e => e.CompanyJob)
                    .WithMany(e => e.CompanyJobDescriptions)
                    .HasForeignKey(e => e.Job);

            modelBuilder.Entity<CompanyJobEducationPoco>()
                    .HasOne(e => e.CompanyJob)
                    .WithMany(e => e.CompanyJobEducations)
                    .HasForeignKey(e => e.Job);

            modelBuilder.Entity<CompanyJobPoco>()
                    .HasOne(e => e.CompanyProfile)
                    .WithMany(e => e.CompanyJobs)
                    .HasForeignKey(e => e.Company);

            modelBuilder.Entity<CompanyJobSkillPoco>()
                .HasOne(e => e.CompanyJob)
                    .WithMany(e => e.CompanyJobSkills)
                    .HasForeignKey(e => e.Job);

            modelBuilder.Entity<CompanyLocationPoco>()
                    .HasOne(e => e.CompanyProfile)
                    .WithMany(e => e.CompanyLocations)
                    .HasForeignKey(e => e.Company);

            modelBuilder.Entity<SecurityLoginsLogPoco>()
                    .HasOne(e => e.SecurityLogin)
                    .WithMany(e => e.SecurityLoginsLogs)
                    .HasForeignKey(e => e.Login);

            modelBuilder.Entity<SecurityLoginsRolePoco>()
                   .HasOne(e => e.SecurityLogin)
                   .WithMany(e => e.SecurityLoginsRoles)
                   .HasForeignKey(e => e.Login);

            modelBuilder.Entity<SecurityLoginsRolePoco>()
                   .HasOne(e => e.SecurityRole)
                   .WithMany(e => e.SecurityLoginsRoles)
                   .HasForeignKey(e => e.Role);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyJobDescriptionPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });

            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
            {
                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });

            modelBuilder.Entity<CompanyProfilePoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });

            modelBuilder.Entity<CompanyJobPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });

            modelBuilder.Entity<CompanyLocationPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });

            modelBuilder.Entity<CompanyJobEducationPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });

            modelBuilder.Entity<CompanyJobSkillPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<SecurityLoginPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<SecurityLoginsRolePoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<ApplicantProfilePoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<ApplicantEducationPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<ApplicantJobApplicationPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<ApplicantSkillPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion();
            });
        }
    }
}