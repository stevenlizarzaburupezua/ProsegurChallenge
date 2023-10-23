using AutoMapper;
using Prosegur.GAP.Domain.Entities;
//using Prosegur.GAP.Domain.VO.Login;
using Prosegur.GAP.DTO;
using Prosegur.GAP.DTO.Login.Response;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Prosegur.GAP.DTO.Mantenimiento.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prosegur.GAP.Infrastructure.CrossCutting.MapperProfile
{
    public class MapperExtensions : Profile
    {
        public MapperExtensions()
        {
            #region USUARIO

            #region DTO => ENT 

            CreateMap<RegistrarUsuarioRequest, Usuario>().AfterMap((src, dst) =>
            {
                dst.ID_ROL = 1; // ROL CUANDO SE REGISTRA LA PRIMERA VEZ USUARIO
                dst.LOG_USUARIO = src.LogUsuario;
                dst.CONTRASENA = src.Contrasena;
                dst.PRIMER_NOMBRE = src.PrimerNombre;
                dst.SEGUNDO_NOMBRE = src.SegundoNombre;
                dst.PRIMER_APELLIDO = src.PrimerApellido;
                dst.SEGUNDO_APELLIDO = src.SegundoApellido;
                dst.EMAIL = src.Email;
                dst.DIRECCION = src.Direccion;
                dst.TELEFONO = src.Telefono;
                dst.FLAG_ACTIVO = true;
                dst.IMG_USUARIO = null;
                dst.FEC_REGISTRO = DateTime.Now;
            });

            CreateMap<ModificarUsuarioRequest, Usuario>().AfterMap((src, dst) =>
            {
                dst.ID_ROL = src.IdRol;
                dst.ID_USUARIO = src.Id;
                dst.PRIMER_NOMBRE = src.PrimerNombre;
                dst.SEGUNDO_NOMBRE = src.SegundoNombre;
                dst.PRIMER_APELLIDO = src.PrimerApellido;
                dst.SEGUNDO_APELLIDO = src.SegundoApellido;
                dst.EMAIL = src.Email;
                dst.DIRECCION = src.Direccion;
                dst.TELEFONO = src.Telefono;
                dst.FLAG_ACTIVO = true;
                dst.IMG_USUARIO = null;
                dst.FEC_REGISTRO = DateTime.Now;
            });


            CreateMap<EliminarUsuarioRequest, Usuario>().AfterMap((src, dst) =>
            {
                dst.ID_USUARIO = src.Id;
                dst.LOG_USUARIO = src.LogUsuario;
            });

            #endregion

            #region ENT => DTO 

            CreateMap<Usuario, UsuarioDTO>().AfterMap((src, dst) =>
            {
                dst.IdRol = src.ID_ROL;
                dst.RolDescripcion = src.Rol.DESCRIPCION;
                dst.Id = src.ID_USUARIO;
                dst.LogUsuario = src.LOG_USUARIO;
                dst.PrimerNombre = src.PRIMER_NOMBRE;
                dst.SegundoNombre = src.SEGUNDO_NOMBRE;
                dst.PrimerApellido = src.PRIMER_APELLIDO;
                dst.SegundoApellido = src.SEGUNDO_APELLIDO;
                dst.Email = src.EMAIL;
                dst.Direccion = src.DIRECCION;
                dst.Telefono = src.TELEFONO;
                dst.FlagActivo = src.FLAG_ACTIVO;
                dst.Imagen = src.IMG_USUARIO;
                dst.FechaRegistro = src.FEC_REGISTRO;
            });

            CreateMap<Usuario, RegistrarUsuarioDTO>().AfterMap((src, dst) =>
            {
                dst.TransactionSuccess = true;
                dst.LogUsuario = src.LOG_USUARIO;
                dst.IdUsuario = src.ID_USUARIO;
            });

            CreateMap<Usuario, ModificarUsuarioDTO>().AfterMap((src, dst) =>
            {
                dst.TransactionSuccess = true;
                dst.IdRol = src.ID_ROL;
                dst.Id = src.ID_USUARIO;
                dst.LogUsuario = src.LOG_USUARIO;
                dst.PrimerNombre = src.PRIMER_NOMBRE;
                dst.SegundoNombre = src.SEGUNDO_NOMBRE;
                dst.PrimerApellido = src.PRIMER_APELLIDO;
                dst.SegundoApellido = src.SEGUNDO_APELLIDO;
                dst.Email = src.EMAIL;
                dst.Direccion = src.DIRECCION;
                dst.Telefono = src.TELEFONO;
                dst.FlagActivo = src.FLAG_ACTIVO;
                dst.Imagen = src.IMG_USUARIO;
            });

            CreateMap<Usuario, EliminarUsuarioDTO>().AfterMap((src, dst) =>
            {
                dst.TransactionSuccess = true;
                dst.Id = src.ID_USUARIO;
                dst.LogUsuario = src.LOG_USUARIO;
            });

            CreateMap<Usuario, SesionDTO>().AfterMap((src, dst) =>
            {
                dst.IdUsuario = src.ID_USUARIO;
                dst.NombreCompleto = $"{src.PRIMER_NOMBRE} {src.SEGUNDO_NOMBRE} {src.PRIMER_APELLIDO} {src.SEGUNDO_APELLIDO}";
                dst.LogUsuario = src.LOG_USUARIO;
                dst.Rol = src.Rol.ROL;
            });

            #endregion

            #endregion

            #region ROL

            #region DTO => ENT 

            CreateMap<RegistrarRolRequest, Rol>().AfterMap((src, dst) =>
            {
                dst.ROL = src.Nombre;
                dst.DESCRIPCION = src.Descripcion;
                dst.FLAG_ACTIVO = true;
                dst.FEC_REGISTRO = Convert.ToDateTime(src.FechaRegistro);
            });

            CreateMap<ModificarRolRequest, Rol>().AfterMap((src, dst) =>
            {
                dst.ID_ROL = src.Id;
                dst.ROL = src.Nombre;
                dst.DESCRIPCION = src.Descripcion;
                dst.FLAG_ACTIVO = src.FlagActivo;
            });

            CreateMap<EliminarRolRequest, Rol>().AfterMap((src, dst) =>
            {
                dst.ID_ROL = src.Id;
                dst.ROL = src.Nombre;
            });

            #endregion

            #region ENT => DTO

            CreateMap<Rol, RolDTO>().AfterMap((src, dst) =>
            {
                dst.Id = src.ID_ROL;
                dst.Nombre = src.ROL;
                dst.Descripcion = src.DESCRIPCION;
                dst.FlagActivo = src.FLAG_ACTIVO;
                dst.FechaRegistro = src.FEC_REGISTRO;
            });

            #endregion

            #endregion



        }
    }
}
