﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviseAPI.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DeviseEntities1 : DbContext
    {
        public DeviseEntities1()
            : base("name=DeviseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hablon> Hablon { get; set; }
        public virtual DbSet<InternetUser> InternetUser { get; set; }
        public virtual DbSet<Naklad_Prodag> Naklad_Prodag { get; set; }
        public virtual DbSet<Nakladna> Nakladna { get; set; }
        public virtual DbSet<PodTip> PodTip { get; set; }
        public virtual DbSet<Pokup> Pokup { get; set; }
        public virtual DbSet<Postavhick> Postavhick { get; set; }
        public virtual DbSet<Reg> Reg { get; set; }
        public virtual DbSet<Sklad> Sklad { get; set; }
        public virtual DbSet<Sotrudnic> Sotrudnic { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tip> Tip { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }
        public virtual DbSet<J_Postupl> J_Postupl { get; set; }
        public virtual DbSet<J_Vibit> J_Vibit { get; set; }
        public virtual DbSet<Sost_Naklad_Prodag> Sost_Naklad_Prodag { get; set; }
        public virtual DbSet<Sost_Nakladna> Sost_Nakladna { get; set; }
        public virtual DbSet<Sostav_Partii> Sostav_Partii { get; set; }
        public virtual DbSet<Sostav_Postupl_Naklad> Sostav_Postupl_Naklad { get; set; }
        public virtual DbSet<Sostav_Vibitie_Naklad> Sostav_Vibitie_Naklad { get; set; }
        public virtual DbSet<View_J_Postupl> View_J_Postupl { get; set; }
        public virtual DbSet<View_J_Vibit> View_J_Vibit { get; set; }
        public virtual DbSet<View_Naklad_Prodag> View_Naklad_Prodag { get; set; }
        public virtual DbSet<View_Nakladna> View_Nakladna { get; set; }
        public virtual DbSet<View_PodTip> View_PodTip { get; set; }
        public virtual DbSet<View_Pokup> View_Pokup { get; set; }
        public virtual DbSet<View_Sklad> View_Sklad { get; set; }
        public virtual DbSet<View_Sost_Naklad_Prodag> View_Sost_Naklad_Prodag { get; set; }
        public virtual DbSet<View_Sost_Nakladna> View_Sost_Nakladna { get; set; }
        public virtual DbSet<View_Sostav_Partii> View_Sostav_Partii { get; set; }
        public virtual DbSet<View_Sostav_Postupl_Naklad> View_Sostav_Postupl_Naklad { get; set; }
        public virtual DbSet<View_Sostav_Vibitie_Naklad> View_Sostav_Vibitie_Naklad { get; set; }
        public virtual DbSet<View_Sotrudnic> View_Sotrudnic { get; set; }
        public virtual DbSet<View_Tovar> View_Tovar { get; set; }
    
        public virtual ObjectResult<Hranim_PodTip_Result> Hranim_PodTip(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hranim_PodTip_Result>("Hranim_PodTip", iDParameter);
        }
    
        public virtual ObjectResult<Hranim_Sost_J_Vibit_Result> Hranim_Sost_J_Vibit(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hranim_Sost_J_Vibit_Result>("Hranim_Sost_J_Vibit", iDParameter);
        }
    
        public virtual ObjectResult<Hranim_Sost_Naklad_Prodag_Result> Hranim_Sost_Naklad_Prodag(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hranim_Sost_Naklad_Prodag_Result>("Hranim_Sost_Naklad_Prodag", iDParameter);
        }
    
        public virtual ObjectResult<Hranim_Sostav_Patii_Sklad_Result> Hranim_Sostav_Patii_Sklad(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hranim_Sostav_Patii_Sklad_Result>("Hranim_Sostav_Patii_Sklad", iDParameter);
        }
    
        public virtual ObjectResult<Hranim_View_Sost_Nakladna_Result> Hranim_View_Sost_Nakladna(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Hranim_View_Sost_Nakladna_Result>("Hranim_View_Sost_Nakladna", iDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<View_Sostav_Postupl_Nakla_Result> View_Sostav_Postupl_Nakla(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<View_Sostav_Postupl_Nakla_Result>("View_Sostav_Postupl_Nakla", iDParameter);
        }
    }
}
