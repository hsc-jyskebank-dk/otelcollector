# otelcollector
otel collector distribution

## components
### receivers
[filelog](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/receiver/filelogreceiver/README.md)
[filestats](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/receiver/filestatsreceiver/README.md)
[hostmetrics](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/receiver/hostmetricsreceiver/README.md)
[loki](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/receiver/lokireceiver)
[otlp](https://github.com/open-telemetry/opentelemetry-collector/blob/main/receiver/otlpreceiver/README.md)
[prometheus](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/receiver/prometheusreceiver/README.md)
[windowseventlog](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/receiver/windowseventlogreceiver/README.md)
[webhookevent](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/receiver/webhookeventreceiver)
[windowsperfcounters](opentelemetry-collector-contrib/receiver/windowsperfcountersreceiver)

### exporters
[debug](https://pkg.go.dev/go.opentelemetry.io/collector/exporter/debugexporter)
[file](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/fileexporter/README.md)
[loki](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/lokiexporter/README.md)
[otlp](https://pkg.go.dev/go.opentelemetry.io/collector/exporter/otlpexporter)
[prometheus](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/prometheusexporter/README.md)
[prometheus-remote-write](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/exporter/prometheusremotewriteexporter/README.md)

### processors
[batch](https://pkg.go.dev/go.opentelemetry.io/collector/processor/batchprocessor)
[memory-limiter](https://pkg.go.dev/go.opentelemetry.io/collector/processor/memorylimiterprocessor)
[filter](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/processor/filterprocessor/README.md)
[attributes](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/processor/attributesprocessor/README.md)
[logtransform](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/processor/logstransformprocessor)
[metricstransform](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/processor/metricstransformprocessor)
[span](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/processor/spanprocessor)
[transform](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/processor/transformprocessor)
[resource-detection](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/processor/resourcedetectionprocessor/README.md)

### extensions
[basic-auth](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/extension/basicauthextension)
[headers-setter](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/extension/headerssetterextension/README.md)
[healthcheck](https://github.com/open-telemetry/opentelemetry-collector-contrib/blob/main/extension/healthcheckextension/README.md)
[oauth2-clientauth](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/extension/oauth2clientauthextension)
[filestorage](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/extension/storage/filestorage)
[dbstorage](https://github.com/open-telemetry/opentelemetry-collector-contrib/tree/main/extension/storage/dbstorage)
[zpages](https://pkg.go.dev/go.opentelemetry.io/collector/extension/zpagesextension)
