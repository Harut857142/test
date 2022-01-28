#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /
COPY ["./Gas.Admin/Gas.Admin.csproj", "Gas.Admin/"]
COPY ["./Gas.Shared/Gas.Shared.csproj", "Gas.Shared/"]
RUN dotnet restore "Gas.Admin/Gas.Admin.csproj"
COPY ./ .
WORKDIR "/Gas.Admin"
RUN dotnet build "Gas.Admin.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Gas.Admin.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Gas.Admin.dll"]
