# servico-transferencia-storage

```
************** TUDO **************

===== Autenticação =====
gcloud auth activate-service-account --key-file [KEY_FILE]

===== Revogar autenticação =====
gcloud auth revoke [ACCOUNTS …] [--all] [GCLOUD_WIDE_FLAG …]

===== Listar configs =====
gcloud config configurations list

===== Criar projetos =====
gcloud projects create PROJECT_ID --folder=FOLDER_ID
-- ou --
gcloud projects create PROJECT_ID --organization=ORGANIZATION_ID

===== Listar projetos =====
gcloud projects list

===== Criar buckets =====
gsutil mb [-c nearline] gs://some-bucket

===== Listar buckets =====
gsutil ls
-- ou --
gsutil ls gs://

===== Cópia de arquivos =====
gsutil cp [OBJECT_LOCATION] gs://[DESTINATION_BUCKET_NAME]/

===== Deletar arquivos =====
gsutil rm gs://[BUCKET_NAME]/[OBJECT_NAME]


************** SERVICE ACCOUNTS **************

===== Criar service account =====
gcloud iam service-accounts create [SA-NAME] \
    --description "[SA-DESCRIPTION]" \
    --display-name "[SA-DISPLAY-NAME]"

===== Listar service accounts =====
gcloud iam service-accounts list

===== Atribuir papel ao service account =====
gcloud projects add-iam-policy-binding my-project-123 \
  --member serviceAccount:my-sa-123@my-project-123.iam.gserviceaccount.com \
  --role roles/editor

===== Ver papeis atribuídos a uma service account =====
gcloud iam service-accounts get-iam-policy \
    my-sa-123@my-project-123.iam.gserviceaccount.com

===== Criar chave de service account =====
gcloud iam service-accounts keys create ~/key.json \
  --iam-account [SA-NAME]@[PROJECT-ID].iam.gserviceaccount.com
(obs: o usuário deve ter o papel "arministrador de chave de conta de serviço")

===== Listar chaves de service accounts =====
gcloud iam service-accounts keys list \
    --iam-account [SA-NAME]@[PROJECT-ID].iam.gserviceaccount.com
```