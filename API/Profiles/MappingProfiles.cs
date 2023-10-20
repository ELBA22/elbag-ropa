using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Cargo, CargoDto>().ReverseMap();
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Departamento, DepartamentoDto>().ReverseMap();
            CreateMap<DetalleOrden, DetalleOrdenDto>().ReverseMap();
            CreateMap<DetalleVenta, DetalleVentaDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Empresa, EmpresaDto>().ReverseMap();
            CreateMap<Estado, EstadoDto>().ReverseMap();
            CreateMap<FormaPago, FormaPagoDto>().ReverseMap();
            CreateMap<Genero, GeneroDto>().ReverseMap();
            CreateMap<Insumo, InsumoDto>().ReverseMap();
            CreateMap<InsumoPrenda, InsumoPrendaDto>().ReverseMap();
            CreateMap<InsumoProveedor, InsumoProveedorDto>().ReverseMap();
             CreateMap<Estado, EstadoDto>().ReverseMap();



        }
        
    }
}