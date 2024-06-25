#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TicketStore.Services.Marketing/TicketStore.Services.Marketing.csproj", "TicketStore.Services.Marketing/"]
RUN dotnet restore "TicketStore.Services.Marketing/TicketStore.Services.Marketing.csproj"
COPY . .
WORKDIR "/src/TicketStore.Services.Marketing"
RUN dotnet build "TicketStore.Services.Marketing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TicketStore.Services.Marketing.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TicketStore.Services.Marketing.dll"]