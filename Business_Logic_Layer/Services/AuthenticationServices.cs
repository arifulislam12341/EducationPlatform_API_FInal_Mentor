using AutoMapper;
using Business_Logic_Layer.BOs;
using Data_Access_Layer;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class AuthenticationServices
    {
        public static MentorTokenModel Auth(MentorModel user)
        {
            var dbuser = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MentorModel, Mentor>())).Map<Mentor>(user);
            var createToken = DataAccess.GetMentorTokenDataAccess().Authenticate(dbuser);
            var returnToken = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MentorToken, MentorTokenModel>())).Map<MentorTokenModel>(createToken);
            return returnToken;

        }
        public static bool Logout(string token)
        {
            return DataAccess.GetMentorTokenDataAccess().Logout(token);
        }
    }
}
