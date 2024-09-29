<script setup lang="ts">
import { useProjectsQuery, useGrantsQuery, type Project, type Grant } from '@/data/home'
import { computed, ref, watch } from 'vue'
import ProjectListItem from '@/components/ProjectListItem.vue'
import GrantListItem from '@/components/GrantListItem.vue'

const tags = ['Ekologia', 'Nauka', 'Zdrowie', 'Rynek pracy', 'Edukacja']
const tab = ref(1)

const selectedTags = ref<string[]>([])
const search = ref<string>('')

const { projects } = useProjectsQuery()
const { grants } = useGrantsQuery()

function matchProjectBySearch(project: Project) {
  return (
    search.value !== '' &&
    (project.name.includes(search.value) || project.ngoName.includes(search.value))
  )
}

function matchGrantBySearch(grant: Grant) {
  return (
    search.value !== '' &&
    (grant.name.includes(search.value) || grant.companyName.includes(search.value))
  )
}

function matchByTags(tags: string[]) {
  return tags.findIndex((tag) => selectedTags.value.includes(tag)) > -1
}

function filtersAreEmpty() {
  return search.value === '' && selectedTags.value.length === 0
}

const filteredProjects = computed<Project[]>(() => {
  return (
    projects.value?.filter(
      (p) => filtersAreEmpty() || matchProjectBySearch(p) || matchByTags(p.tags)
    ) ?? []
  )
})
const filteredGrants = computed<Grant[]>(() => {
  return (
    grants.value?.filter(
      (g) => filtersAreEmpty() || matchGrantBySearch(g) || matchByTags(g.tags)
    ) ?? []
  )
})
</script>

<template>
  <v-row>
    <v-col cols="4">
      <v-text-field
          prepend-inner-icon="mdi-magnify"
          v-model="search"
          label="Szukaj"
          density="compact"
          variant="solo-filled"
          rounded="pill"
      />
    </v-col>
    <v-col cols="4">
      <v-autocomplete
          class="elevation-0"
          prepend-inner-icon="mdi-magnify"
          chips
          density="compact"
          closable-chips
          multiple
          label="Locations"
          variant="solo-filled"
          rounded="pill"
          :items="['California', 'Colorado', 'Florida', 'Georgia', 'Texas', 'Wyoming']"
      ></v-autocomplete>
    </v-col>
    <v-col cols="4">
      <v-chip-group multiple v-model="selectedTags">
        <v-chip variant="outlined" v-for="tag in tags" class="tag" :value="tag" color="primary">
          {{ tag }}
        </v-chip>
      </v-chip-group>
    </v-col>
  </v-row>
  
  <v-row>

    <v-col cols="6">
      <v-row>
        
        <v-col>
          <v-tabs v-model="tab" color="secondary">
            <v-tab :value="1">Projekty</v-tab>
            <v-tab :value="2">Granty</v-tab>
          </v-tabs>
        </v-col>
      </v-row>
      <v-row>
        <v-col>
          <v-tabs-window v-model="tab">
            <v-tabs-window-item :value="1">
              <ProjectListItem v-for="item in filteredProjects" :key="item.slug" :item="item" />
            </v-tabs-window-item>
            <v-tabs-window-item :value="2">
              <GrantListItem v-for="item in filteredGrants" :key="item.slug" :item="item" />
            </v-tabs-window-item>
          </v-tabs-window>
        </v-col>
      </v-row>
    </v-col>

    <v-col cols="6">
      <img class="fin" src="@/assets/finished.png" />
    </v-col>

  </v-row>
  

</template>

<style scoped lang="scss">
.tag {
  cursor: pointer;
  margin-right: 5px;

  &:hover {
    background-color: lightgrey;
  }
}

.fin{
  width: 100%;
}
</style>
