using AspNetEcommerce.API.dto;

namespace AspNetEcommerce.API.utils;

public static class QueryExtensions
{
    public static IQueryable<T> ApplyPagination<T>(
        this IQueryable<T> query, PageRequest pageRequest)
    {
        var skip = (pageRequest.PageNumber - 1) * pageRequest.PageSize;
        return query.Skip(skip).Take(pageRequest.PageSize);
    }
}