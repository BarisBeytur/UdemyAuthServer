using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Service
{
    public static class ObjectMapper
    {

        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });
            return config.CreateMapper();
        });
        // bu kısım lazy initialization yaparak, AutoMapper'ın tek bir instance'ını oluşturup,
        // her seferinde yeni bir instance oluşturulmasını engellemek için yapıldı.

        public static IMapper Mapper => lazy.Value; // => ile property'nin get metodunu yazmış olduk.

    }
}
