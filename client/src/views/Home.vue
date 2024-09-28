<script setup lang="ts">
import { useHomeQuery } from '@/data/home'
import { ref } from 'vue'

const tags = ['ekologia','nauka'];
const tab = ref(1);

const query = useHomeQuery();
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
          Projekty
        </v-tabs-window-item>
        <v-tabs-window-item :value="2">
          <p>Granty</p>
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
