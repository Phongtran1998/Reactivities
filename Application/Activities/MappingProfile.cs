﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Domain;

namespace Application.Activities
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, ActivityDto>();
            CreateMap<UserActivity, AttendeeDto>()
                .ForMember(des => des.Username, o => o.MapFrom(s => s.AppUser.UserName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName));

        }
    }
}
