# Local development

Run Vite
```bash
cd client
npm install
npm run dev
```
Run main project
```bash
cd SocialBridge.Main
dotnet restore
dotnet run
```

#### Migrations
 
List of migrations:
`dotnet ef migrations list`

Add migration:
`dotnet ef migrations add <migration-name>`

Remove last migration:
`dotnet ef migrations remove`

Apply migration:
`dotnet ef database update`
