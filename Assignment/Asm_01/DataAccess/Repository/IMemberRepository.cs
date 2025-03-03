﻿using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> findAll();
        IEnumerable <MemberObject> findByIdAndName(string id, string name);
        MemberObject findById(string id);
        IEnumerable<MemberObject> findByName(string name);
        IEnumerable<MemberObject> filterByCountryAndCity(string country, string city);
        IEnumerable<MemberObject> filterByCountry(string country);
        IEnumerable<MemberObject> filterByCity(string city);
        void insert(MemberObject member);
        void remove(string id);
        void update(MemberObject member);

    }
}
