#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TicketStore.Gateway.WebBff/TicketStore.Gateway.WebBff.csproj", "TicketStore.Gateway.WebBff/"]
COPY ["TicketStore.Gateway.Shared/TicketStore.Gateway.Shared.csproj", "TicketStore.Gateway.Shared/"]
RUN dotnet restore "TicketStore.Gateway.WebBff/TicketStore.Gateway.WebBff.csproj"
COPY . .
WORKDIR "/src/TicketStore.Gateway.WebBff"
RUN dotnet build "TicketStore.Gateway.WebBff.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TicketStore.Gateway.WebBff.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TicketStore.Gateway.WebBff.dll"]