namespace TestWithEric.Controllers {

    export class PlanetListController {

        public planets;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/planet')
                .then((response) => {
                    this.planets = response.data;
                });
        }

        public addPlanet(planet) {
            this.$http.post('/api/planet', planet)
                .then((response) => {
                    this.planets.push(response.data);
                })
                .catch((response) => {
                    console.log(response);
                });
        }
    }
}