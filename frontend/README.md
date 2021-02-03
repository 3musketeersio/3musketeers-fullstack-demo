# IOL PoC

## Project setup
```
yarn install
```

### Compiles and hot-reloads for development
```
yarn serve
```

### Compiles and minifies for production
```
yarn build
```

### Run your unit tests
```
yarn test:unit
```

### Run your end-to-end tests
```
yarn test:e2e
```

### Lints and fixes files
```
yarn lint
```

### Customize configuration
See [Configuration Reference](https://cli.vuejs.org/config/).

## How to obtain a JWT token from Auth0

There are 2 types of access tokens:
* Opague token: used for Auth0 Management API e.g /userinfo
* JWT token: used for custom API authorization

By default, getTokenSilently() method from Auth0 SDK returns an opague token. To get a JWT token, pass in `audience` to the call as such

```
const accessToken = client.getTokenSilently({
    audience: <API_IDENTIFIER>
})
```

Also, when a user uses that JWT token to access the API, he needs to authorize the API to validate against his identity in Auth0. This is because localhost is not a trusted source. One way to work around this is to map your localhost to a different domain
```
127.0.0.1 myapp.dev
```

However, `auth0-spa-js` may complain its not running under a secure origin due to TLS/SSL missing. You can place a proxy in front to avoid this.
