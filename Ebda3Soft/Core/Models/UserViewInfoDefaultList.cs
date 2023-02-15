using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Models
{
    public class UserViewInfoDefaultList : List<UserViewInfo>
    {
        public UserViewInfoDefaultList()
        {
            foreach (var view in SharedView.GetAllViews())
            {
                Add(new UserViewInfo
                {
                    UserViewInfoID = Guid.NewGuid(),
                    ViewID = view.ViewID,
                });
            }
        }
    }
}
