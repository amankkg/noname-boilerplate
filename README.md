# noname project

some random thoughts expressed in client js and server asp.net app

## roadmap (not strict, in progress, to be sorted properly)

### client
1. react & babel
1. flow, with no prop-types (babel-plugin-flow-react-proptypes)
1. eslint, prettier
1. jest
1. code splitting and async loading (react-loadable, react-universal-component)
1. router (redux-first-router)
1. business logic (redux-logic, redux-most)
1. css-in-js (jss)
1. runtime validation?
1. hot reload?

### server
1. editorconfig
1. Serilog and structured logs
1. xunit and contnuous testing
1. feature scaffolding
1. CQRS infrastructure (Byndyusoft.Dotnet.Core.Infrastructure)
1. entity, value object base
1. railway-oriented flow
1. input validation (FluentValidation)
1. global exception filter
1. global model validation filter
1. api security

### ops
1. script to run whole app?
1. browsersync
1. Cake to build .NET code
1. modern and transpiled client output (https://philipwalton.com/articles/deploying-es2015-code-in-production-today/)
1. webpack - babel might be enough?
1. infrastructure testing?
1. code de-face git hook (prettier, lint-staged, editorconfig)

### other
1. e2e tests (cypress, headless chrome)
1. REST?
1. SSR
1. PWA, AMP
1. i10/18n
1. error passing
1. code sharing between client and server - resources, enums, schemas, etc. (Bridge.NET or similar)
1. access control and feature toggles
