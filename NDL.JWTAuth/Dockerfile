#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NDL.JWTAuth/NDL.JWTAuth.csproj", "NDL.JWTAuth/"]
RUN dotnet restore "NDL.JWTAuth/NDL.JWTAuth.csproj"
COPY . .
WORKDIR "/src/NDL.JWTAuth"
RUN dotnet build "NDL.JWTAuth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NDL.JWTAuth.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NDL.JWTAuth.dll"]