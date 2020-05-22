FROM mcr.microsoft.com/dotnet/aspnet:5.0.5-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0.202-buster-slim AS publish
WORKDIR /src/learning-csharp-blazor
COPY ["src/learning-csharp-blazor/learning-csharp-blazor.csproj", "."]
RUN dotnet restore "learning-csharp-blazor.csproj"
COPY src/learning-csharp-blazor .
WORKDIR "/src/learning-csharp-blazor"
RUN dotnet build "learning-csharp-blazor.csproj" -c Release -o /app/build
RUN dotnet publish "learning-csharp-blazor.csproj" -c Release -o /app/publish

FROM nginx:1.20.0 AS stage-nginx
WORKDIR /app
COPY --from=publish /app/publish/wwwroot .
COPY /src/learning-csharp-blazor/nginx.conf /etc/nginx/nginx.conf
CMD ["nginx", "-g", "daemon off;"]
