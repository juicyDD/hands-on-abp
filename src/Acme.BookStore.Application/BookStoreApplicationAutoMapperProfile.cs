using Acme.BookStore.Entities.Commons;
using Acme.BookStore.Models;
using Acme.BookStore.Models.BoPhan;
using Acme.BookStore.Models.NhanVien;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            //nhân viên
            CreateMap<NhanVien, NhanVienResponse>();
            CreateMap<NhanVienRequest, NhanVien>();
            CreateMap<NhanVienResponse, NhanVienRequest>();



            //bộ phận
            CreateMap<BoPhan, BoPhanResponse>();
            CreateMap<BoPhanRequest, BoPhan>();
            CreateMap<BoPhanResponse, BoPhanRequest>();
        }
    }
}
