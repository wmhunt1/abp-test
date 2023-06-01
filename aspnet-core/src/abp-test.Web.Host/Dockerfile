FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/abp-test.Web.Host/abp-test.Web.Host.csproj", "src/abp-test.Web.Host/"]
COPY ["src/abp-test.Web.Core/abp-test.Web.Core.csproj", "src/abp-test.Web.Core/"]
COPY ["src/abp-test.Application/abp-test.Application.csproj", "src/abp-test.Application/"]
COPY ["src/abp-test.Core/abp-test.Core.csproj", "src/abp-test.Core/"]
COPY ["src/abp-test.EntityFrameworkCore/abp-test.EntityFrameworkCore.csproj", "src/abp-test.EntityFrameworkCore/"]
WORKDIR "/src/src/abp-test.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/abp-test.Web.Host", "src/abp-test.Web.Host"]
COPY ["src/abp-test.Web.Core", "src/abp-test.Web.Core"]
COPY ["src/abp-test.Application", "src/abp-test.Application"]
COPY ["src/abp-test.Core", "src/abp-test.Core"]
COPY ["src/abp-test.EntityFrameworkCore", "src/abp-test.EntityFrameworkCore"]
WORKDIR "/src/src/abp-test.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "abp-test.Web.Host.dll"]
