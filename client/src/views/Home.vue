<script setup lang="ts">
import { useProjectsQuery, useGrantsQuery } from '@/data/home'
import { ref } from 'vue'
import ProjectListItem from '@/components/ProjectListItem.vue'
import GrantListItem from '@/components/GrantListItem.vue'

const tags = ['ekologia','nauka'];
const tab = ref(1);

const { projects } = useProjectsQuery();
const { grants } = useGrantsQuery()
</script>

<template>
  <v-row>
    <v-col cols="3">
      <v-text-field
        variant="outlined"
        label="Szukaj"
        density="compact"
      />
    </v-col>
    <v-col>
      <v-chip variant="outlined" v-for="tag in tags" class="tag">
        {{tag}}
      </v-chip>
    </v-col>
  </v-row>
  <v-row>
    <v-col>
        <v-tabs
          v-model="tab"
          color="secondary"
        >
          <v-tab :value="1">Projekty</v-tab>
          <v-tab :value="2">Granty</v-tab>
        </v-tabs>
      </v-col>
  </v-row>
  <v-row>
    <v-col>
      <v-tabs-window v-model="tab">
        <v-tabs-window-item :value="1">
          <ProjectListItem v-for="item in projects" :key="item.slug" :item="item" />
        </v-tabs-window-item>
        <v-tabs-window-item :value="2">
          <GrantListItem v-for="item in grants" :key="item.slug" :item="item" />
        </v-tabs-window-item>
      </v-tabs-window>
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
</style>
