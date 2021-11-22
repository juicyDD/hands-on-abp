using Acme.BookStore.Entities.Commons;
using Acme.BookStore.Models;
using Acme.BookStore.Models.BoPhan;
using Acme.BookStore.Models.NhanVien;
using Acme.BookStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Commons
{
    public class NhanVienAppService : CrudAppService<NhanVien,
            NhanVienResponse, Guid, PagedAndSortedResultRequestDto,
            NhanVienRequest, NhanVienRequest>,
            INhanVienAppService
    {
        public NhanVienAppService(
            IRepository<NhanVien, Guid> repository) : base(repository)
        {

        }
    }
}
