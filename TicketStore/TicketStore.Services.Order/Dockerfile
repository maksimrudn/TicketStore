#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TicketStore.Services.Order/TicketStore.Services.Ordering.csproj", "TicketStore.Services.Order/"]
COPY ["TicketStore.Integration.Messages/TicketStore.Integration.Messages.csproj", "TicketStore.Integration.Messages/"]
COPY ["TicketStore.Integration.MessagingBus/TicketStore.Integration.MessagingBus.csproj", "TicketStore.Integration.MessagingBus/"]
RUN dotnet restore "TicketStore.Services.Order/TicketStore.Services.Ordering.csproj"
COPY . .
WORKDIR "/src/TicketStore.Services.Order"
RUN dotnet build "TicketStore.Services.Ordering.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TicketStore.Services.Ordering.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TicketStore.Services.Ordering.dll"]