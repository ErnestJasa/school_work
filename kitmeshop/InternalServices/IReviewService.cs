using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalServices
{
    public interface IReviewService
    {
        Review Add(Guid id);

        public void SaveToDb([Bind("ReviewText,ProductId")] Review model);

    }
}
