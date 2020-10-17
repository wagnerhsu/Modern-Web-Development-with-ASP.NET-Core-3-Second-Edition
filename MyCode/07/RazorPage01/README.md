## 2020-10-17
- Create empty web application
- Remove the following
```cs
endpoints.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Hello World!");
});
```