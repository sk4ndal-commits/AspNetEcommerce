namespace AspNetEcommerce.API.dto;

public record PageResponse<T>(
    IEnumerable<T> Items,
    int Total,
    int PageNumber,
    int PageSize);