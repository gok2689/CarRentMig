using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    #region Interface
    public interface IEntity
    {
         int ID { get; set; }
    
    }

    public interface IDefinitionTable
    {
        int ID { get; set; }
        string Name { get; set; }
    
    }

    public interface IDeletable
    {
      bool IsDeleted { get; set; }
    }
    public interface ITableEntity :IEntity,IDeletable
    { 
        int CreateBy { get; set; }
        DateTime? CreateDateTime { get; set; }
        int UpdateBy { get; set; }
        DateTime? UpdateDateTime { get; set; }
    }
    #endregion
    public class Entity : IEntity
    {
        [Key]
        public int ID { get; set; }
    }

    public class TableEntity:Entity,IEntity,IDefinitionTable,IDeletable,ITableEntity
    {
        [UIHint(CRMUIHints.SysUser)]
        public int CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDateTime { get; set; }

        [UIHint(CRMUIHints.SysUser)]
        public int UpdateBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDateTime { get; set; }

        [Display(Name = "Sil")]
        public bool IsDeleted { get; set; }
    }
    public class DefinitionTableEntity : TableEntity, ITableEntity,IEntity, IDeletable, IDefinitionTable
    {
        [MaxLength(50)]
        [Display(Name = "İsim")]
        [Required()]
        public string Name { get; set; }
    }
}
