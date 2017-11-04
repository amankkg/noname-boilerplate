# noname project

some random thoughts expressed in client js and server asp.net app

## desired features

### client
1. **+** react & babel
1. **+** flow, with no prop-types (babel-plugin-flow-react-proptypes)
1. **+** eslint, prettier, lint-staged
1. **+-** modern and legacy client bundles (https://philipwalton.com/articles/deploying-es2015-code-in-production-today/)  **_no webpack yet_**
1. jest
1. code splitting and async loading (react-loadable, react-universal-component)
1. router (redux-first-router)
1. side effects (redux-logic, redux-most)
1. css-in-js (jss)
1. validation - schema? forms? runtime?
1. logging - structured? sync actions? logux?
1. webpack - babel might be enough?
1. browsersync - separate npm script? with hot reload?
1. hot reload - least priority

### server
1. editorconfig rules & lint-staged
1. Serilog and structured logs
1. xunit and contnuous testing
1. feature scaffolding
1. CQRS infrastructure (Byndyusoft.Dotnet.Core.Infrastructure)
1. entity, value object base
1. railway-oriented flow helpers (http://enterprisecraftsmanship.com/ blogposts)
1. input validation (FluentValidation)
1. global exception filter
1. global model validation filter
1. api security
1. Cake to build .NET code

### other
1. script to run whole app w/ hot-reload, browsersync (aspnet-starter-kit)?
1. infrastructure testing?
1. e2e tests (cypress, headless chrome)
1. REST?
1. SSR
1. PWA, AMP
1. i10/18n
1. error passing
1. code sharing C# & JS - resources, enums, schemas, etc. (Bridge.NET, babel or F# type provider)?
1. access control and feature toggles
