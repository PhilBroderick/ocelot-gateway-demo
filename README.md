# ocelot-gateway-demo

Backend service with [Ocelot](https://github.com/ThreeMammals/Ocelot) API Gateway to funnel requests. Used for on-going blog posts on [website](https://www.philbroderick.net).

## Blog Posts
* [Part 1 - Building an API Gateway with Ocelot](https://www.philbroderick.net/blog/building-an-api-gateway-with-ocelot)

## Contents

[starter](https://github.com/PhilBroderick/ocelot-gateway-demo/tree/master/starter) - Used for someone wanting to follow along with the blog posts. Contains just the backend service.

[finished](https://github.com/PhilBroderick/ocelot-gateway-demo/tree/master/finished) - Finished solution. Contains the backend service and the Ocelot gateway configured to route requests to backend.

## Development

To use the solution, clone the repository and open the solution under the finished folder.

Ensure both projects are selected to start up, then run the solution. 

Any request made to `https://localhost:5001/products` will be forwarded to `https://localhost:5003/api/products`
