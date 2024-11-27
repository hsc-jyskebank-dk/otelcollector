
The OpenTelemetry Collector offers a vendor-agnostic implementation on how to receive, process and export telemetry data. In addition, it removes the need to run, operate and maintain multiple agents/collectors in order to support open-source telemetry data formats (e.g. Jaeger, Prometheus, etc.) to multiple open-source or commercial back-ends.

Objectives:

    Usable: Reasonable default configuration, supports popular protocols, runs and collects out of the box.
    Performant: Highly stable and performant under varying loads and configurations.
    Observable: An exemplar of an observable service.
    Extensible: Customizable without touching the core code.
    Unified: Single codebase, deployable as an agent or collector with support for traces, metrics and logs.
