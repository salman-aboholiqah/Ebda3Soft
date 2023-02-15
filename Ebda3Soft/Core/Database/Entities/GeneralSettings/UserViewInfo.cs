using DevExpress.XtraEditors.Repository;
using Ebda3Soft.Core.Enums;
using Ebda3Soft.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.GeneralSettings
{
    public class UserViewInfo
    {
        [Display(Order = -1)]
        public Guid UserViewInfoID { get; set; }
        [Display(Order = -1)]
        public virtual User User { get; set; }
        [Display(Order = -1)]
        public Guid ViewID { get; set; }
        private ViewInfo viewInfo;

        [NotMapped]
        public ViewInfo ViewInfo
        {
            get
            {
                if (viewInfo == null || viewInfo?.ViewID != ViewID)
                {
                    viewInfo = SharedView.GetViewByID(ViewID);
                }
                return viewInfo;
            }
            set { viewInfo = value; }
        }
        public TransactionType TransactionType { get; set; }
    }
}
