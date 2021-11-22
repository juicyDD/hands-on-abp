﻿using Acme.BookStore.Models.BoPhan;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Services
{
    public interface IBoPhanAppService :
        ICrudAppService<
                BoPhanResponse,
                Guid,
                PagedAndSortedResultRequestDto,
                BoPhanRequest,
                BoPhanRequest>
    {
    }
}
