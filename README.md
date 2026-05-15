# apire deploy failed

## aspire doctor
```
aspire doctor

Aspire 环境检查
===========

.NET SDK
  ✔  .NET 10.0.300 installed (x64)

容器运行时
  ✔  Docker Desktop detected and running (version 29.4.3)

环境
  ✔  HTTPS development certificate is trusted

摘要: 3 通过,0 警告， 0 失败
```

## aspire publish
```
aspire publish -o docker-compose-artifacts
🔬 正在检查项目类型...: AspireDeployDemo.AppHost.csproj
🛠  正在生成应用主机... AspireDeployDemo.AppHost.csproj
07:07:46 (validate-compute-environments) → Starting validate-compute-environments...
07:07:46 (validate-compute-environments) ✓ validate-compute-environments completed successfully
07:07:46 (prepare-deployment-targets-compose) → Starting prepare-deployment-targets-compose...
07:07:46 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for compose-dashboard
07:07:46 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for apiservice
07:07:46 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for webfrontend
07:07:46 (prepare-deployment-targets-compose) ✓ prepare-deployment-targets-compose completed successfully
07:07:46 (validate-docker-compose) → Starting validate-docker-compose...
07:07:46 (validate-docker-compose) ✓ validate-docker-compose completed successfully
07:07:46 (before-start) → Starting before-start...
07:07:46 (before-start) ✓ before-start completed successfully
07:07:46 (pipeline-execution) → Starting pipeline-execution...
07:07:46 (publish-compose) → Starting publish-compose...
07:07:46 (publish-compose) i [INF] Generating Compose output
07:07:46 (publish-compose) → Writing the Docker Compose file to the output path.
07:07:46 (publish-compose) ✓ Docker Compose file written successfully to
D:\repos\aspire-deploy-demo\AspireDeployDemo.AppHost\docker-compose-artifacts\docker-compose.yaml. (0.0s)
07:07:46 (publish-compose) ✓ publish-compose completed successfully
07:07:46 (publish) → Starting publish...
07:07:46 (publish) ✓ publish completed successfully
07:07:46 (pipeline-execution) ✓ Completed successfully
------------------------------------------------------------
✓ 7/7 steps succeeded • Total time: 37.58ms

Steps Summary:
      4.51ms  ✓ prepare-deployment-targets-compose
      4.01ms  ✓ pipeline-execution
      2.07ms  ✓ publish-compose
      1.33ms  ✓ validate-compute-environments
      0.61ms  ✓ validate-docker-compose
      0.48ms  ✓ before-start
      0.46ms  ✓ publish

✓ PIPELINE SUCCEEDED
------------------------------------------------------------
```

## aspire 

```
aspire do prepare-compose --environment staging
🔬 正在检查项目类型...: AspireDeployDemo.AppHost.csproj
🛠  正在生成应用主机... AspireDeployDemo.AppHost.csproj
07:16:58 (validate-compute-environments) → Starting validate-compute-environments...
07:16:58 (validate-compute-environments) ✓ validate-compute-environments completed successfully
07:16:58 (prepare-deployment-targets-compose) → Starting prepare-deployment-targets-compose...
07:16:58 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for compose-dashboard
07:16:58 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for apiservice
07:16:58 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for webfrontend
07:16:58 (prepare-deployment-targets-compose) ✓ prepare-deployment-targets-compose completed successfully
07:16:58 (validate-docker-compose) → Starting validate-docker-compose...
07:16:58 (validate-docker-compose) ✓ validate-docker-compose completed successfully
07:16:58 (before-start) → Starting before-start...
07:16:58 (before-start) ✓ before-start completed successfully
07:16:58 (pipeline-execution) → Starting pipeline-execution...
07:16:58 (process-parameters) → Starting process-parameters...
07:16:58 (publish-compose) → Starting publish-compose...
07:16:58 (validate-build-only-container-references) → Starting validate-build-only-container-references...
07:16:58 (validate-compute-environments) → Starting validate-compute-environments...
07:16:58 (check-container-runtime) → Starting check-container-runtime...
07:16:58 (validate-compute-environments) ✓ validate-compute-environments completed successfully
07:16:58 (validate-build-only-container-references) ✓ validate-build-only-container-references completed successfully
07:16:58 (check-container-runtime) i [INF] Container runtime 'docker-compose' configured via ASPIRE_CONTAINER_RUNTIME.
07:16:58 (publish-compose) i [INF] Generating Compose output
07:16:58 (process-parameters) ✓ process-parameters completed successfully
07:16:58 (deploy-prereq) → Starting deploy-prereq...
07:16:58 (build-prereq) → Starting build-prereq...
07:16:58 (build-prereq) ✓ build-prereq completed successfully
07:16:58 (deploy-prereq) i [INF] Initializing deployment for environment 'staging'
07:16:58 (deploy-prereq) i [INF] Setting default deploy tag 'aspire-deploy-20260515231658' for compute resource(s).
07:16:58 (deploy-prereq) ✓ deploy-prereq completed successfully
07:16:58 (publish-compose) → Writing the Docker Compose file to the output path.
07:16:58 (check-container-runtime) ✗ [ERR] Step 'check-container-runtime' failed.
07:16:58 (check-container-runtime) ✗ Step 'check-container-runtime' failed: No keyed service for type
'Aspire.Hosting.Publishing.IContainerRuntime' using key type 'System.String' has been registered.
07:16:58 (publish-compose) ✓ Docker Compose file written successfully to
07:16:58 (publish-compose) ✓ publish-compose completed successfully
07:16:58 (publish) → Starting publish...
07:16:58 (publish) ✓ publish completed successfully
07:16:58 (pipeline-execution) ✗ [ERR] Step 'check-container-runtime' failed: No keyed service for type
'Aspire.Hosting.Publishing.IContainerRuntime' using key type 'System.String' has been registered.
07:16:58 (pipeline-execution) ✗ Failed
------------------------------------------------------------
✓ 11/13 steps succeeded • ✗ 2 failed • Total time: 46.27ms

Steps Summary:
     13.29ms  ✗ pipeline-execution
     10.27ms  ✓ publish-compose
      7.19ms  ✗ check-container-runtime
      4.84ms  ✓ prepare-deployment-targets-compose
      4.03ms  ✓ process-parameters
      2.58ms  ✓ deploy-prereq
      1.73ms  ✓ validate-build-only-container-references
      1.19ms  ✓ validate-compute-environments
      0.85ms  ✓ validate-compute-environments
      0.54ms  ✓ publish
      0.50ms  ✓ validate-docker-compose
      0.46ms  ✓ build-prereq
      0.45ms  ✓ before-start

✗ PIPELINE FAILED
For more details, add --log-level debug/trace to the command.
```

## aspire deploy
``` aspire deploy
🔬 正在检查项目类型...: AspireDeployDemo.AppHost.csproj
🛠  正在生成应用主机... AspireDeployDemo.AppHost.csproj
07:18:56 (validate-compute-environments) → Starting validate-compute-environments...
07:18:56 (validate-compute-environments) ✓ validate-compute-environments completed successfully
07:18:56 (prepare-deployment-targets-compose) → Starting prepare-deployment-targets-compose...
07:18:56 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for compose-dashboard
07:18:56 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for apiservice
07:18:56 (prepare-deployment-targets-compose) i [INF] Creating Docker Compose resource for webfrontend
07:18:56 (prepare-deployment-targets-compose) ✓ prepare-deployment-targets-compose completed successfully
07:18:56 (validate-docker-compose) → Starting validate-docker-compose...
07:18:56 (validate-docker-compose) ✓ validate-docker-compose completed successfully
07:18:56 (before-start) → Starting before-start...
07:18:56 (before-start) ✓ before-start completed successfully
07:18:56 (pipeline-execution) → Starting pipeline-execution...
07:18:56 (publish-compose) → Starting publish-compose...
07:18:56 (process-parameters) → Starting process-parameters...
07:18:56 (validate-compute-environments) → Starting validate-compute-environments...
07:18:56 (validate-compute-environments) ✓ validate-compute-environments completed successfully
07:18:56 (validate-build-only-container-references) → Starting validate-build-only-container-references...
07:18:56 (check-container-runtime) → Starting check-container-runtime...
07:18:56 (push-prereq) → Starting push-prereq...
07:18:56 (validate-build-only-container-references) ✓ validate-build-only-container-references completed successfully
07:18:56 (push-prereq) ✓ push-prereq completed successfully
07:18:56 (check-container-runtime) i [INF] Container runtime 'docker-compose' configured via ASPIRE_CONTAINER_RUNTIME.
07:18:56 (publish-compose) i [INF] Generating Compose output
07:18:56 (process-parameters) ✓ process-parameters completed successfully
07:18:56 (deploy-prereq) → Starting deploy-prereq...
07:18:56 (build-prereq) → Starting build-prereq...
07:18:56 (build-prereq) ✓ build-prereq completed successfully
07:18:56 (deploy-prereq) i [INF] Initializing deployment for environment 'Production'
07:18:56 (deploy-prereq) i [INF] Setting default deploy tag 'aspire-deploy-20260515231856' for compute resource(s).
07:18:56 (deploy-prereq) ✓ deploy-prereq completed successfully
07:18:56 (publish-compose) → Writing the Docker Compose file to the output path.
07:18:56 (check-container-runtime) ✗ [ERR] Step 'check-container-runtime' failed.
07:18:56 (check-container-runtime) ✗ Step 'check-container-runtime' failed: No keyed service for type
'Aspire.Hosting.Publishing.IContainerRuntime' using key type 'System.String' has been registered.
07:18:56 (publish-compose) ✓ Docker Compose file written successfully to
D:\repos\aspire-deploy-demo\AspireDeployDemo.AppHost\aspire-output\docker-compose.yaml. (0.0s)
07:18:56 (publish-compose) ✓ publish-compose completed successfully
07:18:56 (publish) → Starting publish...
07:18:56 (publish) ✓ publish completed successfully
07:18:56 (pipeline-execution) ✗ [ERR] Step 'check-container-runtime' failed: No keyed service for type
'Aspire.Hosting.Publishing.IContainerRuntime' using key type 'System.String' has been registered.
07:18:56 (pipeline-execution) ✗ Failed
------------------------------------------------------------
✓ 12/14 steps succeeded • ✗ 2 failed • Total time: 45.73ms

Steps Summary:
     12.70ms  ✗ pipeline-execution
     10.38ms  ✓ publish-compose
      6.96ms  ✗ check-container-runtime
      4.35ms  ✓ process-parameters
      4.26ms  ✓ prepare-deployment-targets-compose
      2.34ms  ✓ deploy-prereq
      1.34ms  ✓ validate-build-only-container-references
      1.28ms  ✓ validate-compute-environments
      0.86ms  ✓ push-prereq
      0.48ms  ✓ publish
      0.47ms  ✓ validate-docker-compose
      0.45ms  ✓ build-prereq
      0.44ms  ✓ before-start
      0.42ms  ✓ validate-compute-environments

✗ PIPELINE FAILED
For more details, add --log-level debug/trace to the command.
------------------------------------------------------------
```