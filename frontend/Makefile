RUNNER=docker-compose run --rm

shell:
	docker-compose run nodejs -e /bin/sh

clean:
	$(RUNNER) nodejs rm -rf node_modules/* && rm -rf dist
.PHONY: clean

build:
	$(RUNNER) nodejs yarn && $(RUNNER) nodejs yarn build
.PHONY: build

run:
	$(RUNNER) nodejs yarn run serve
.PHONY: run

# Internal targets

_deploy: 
	$(RUNNER) aws s3 sync ./dist s3://$(AWS_BUCKET) --delete --sse 'AES256' && make _invalidate