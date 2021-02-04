NODEJS_RUNNER=@docker-compose run --rm nodejs

# Main targets
.env:
	@echo "no .env file found, copying from .env.template"
	cp .env.template .env

clean:
	$(NODEJS_RUNNER) rm -rf node_modules && rm -rf dist
.PHONY: clean

build: node_modules
	$(NODEJS_RUNNER) yarn build
.PHONY: build

testUnit: node_modules
	$(NODEJS_RUNNER) yarn test:unit

testE2E: node_modules
	$(NODEJS_RUNNER) yarn test:e2e

run: dist
	@docker-compose run --rm -p 9090:9090 nodejs yarn run serve
.PHONY: run

deploy:
	@echo "Deployed! You are a ninja rockstar!"
.PHONY: deploy

# Helpers targets

shell:
	$(NODEJS_RUNNER) /bin/sh

# This will not run if node_module already exists
node_modules:
	$(NODEJS_RUNNER) yarn install

