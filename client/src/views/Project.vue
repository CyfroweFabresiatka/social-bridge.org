<script setup lang="ts">
import {useRoute} from 'vue-router'
import {useProjectQuery} from '@/data/project/project'

const route = useRoute();
const slug = route.params.slug ?? '';
const {data, isLoading, error} = useProjectQuery(<string>slug)

</script>

<template>
  <div v-if="!isLoading && !error">
    
    <div>

      <v-card class="mb-2 pa-4" style="border-radius:15px" variant="flat" border="border">
        <v-row>
          <v-col>
            <v-card-title>{{ data.name }}</v-card-title>
            <v-card-text>{{ data.ngoName }}, {{ data.city }}


              <div>
                Fundacja Bridge działa na rzecz x, łącząc siły z organizacjami i społecznościami, aby wspólnie realizować innowacyjne projekty. Naszym celem jest [krótkie rozwinięcie celu, np. wsparcie edukacji, rozwój społeczności lokalnych], dzięki czemu tworzymy lepsze warunki dla przyszłych pokoleń. Wspieramy [konkretne grupy/cele] poprzez [konkretne działania, np. programy, wydarzenia], promując współpracę i zrównoważony rozwój.
              </div>
            </v-card-text>
          </v-col>
          <v-col>
            <v-chip variant="outlined" v-for="tag in data.tags" class="tag" :value="tag" color="primary">
              {{ tag }}
            </v-chip>
            <v-card-text>{{ budgetDescription }}</v-card-text>
          </v-col>
        </v-row>
      </v-card>
      <v-btn>
        {{ $t("project.button_interested") }}
      </v-btn>
    </div>
  </div>

</template>

<style scoped>
</style>
