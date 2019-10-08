FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["minimalTemplate/minimalTemplate.csproj", "minimalTemplate/"]
RUN dotnet restore "minimalTemplate/minimalTemplate.csproj"
COPY . .
WORKDIR "/src/minimalTemplate"
RUN dotnet build "minimalTemplate.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "minimalTemplate.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "minimalTemplate.dll"]