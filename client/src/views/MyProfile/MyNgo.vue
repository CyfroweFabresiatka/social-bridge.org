<script setup lang="ts">
import { type Ngo } from '@/data/organisations/ngo'
import { ref } from 'vue'
const props = defineProps<{ ngo: Ngo }>()

const form = ref<Ngo>({ ...props.ngo })
</script>

<template>
  <v-card class="card">
    <v-form>
      <v-text-field label="Nazwa" v-model="form.name" clearable />
      <v-textarea label="Opis" v-model="form.description" clearable />
      <v-text-field label="Lokalizacja" v-model="form.location" clearable />
      <v-autocomplete
        chips
        closable-chips
        multiple
        label="Tagi"
        v-model="form.tags"
        :items="['Środowisko', 'Zwierzęta', 'Rynek pracy', 'Dzieci', 'Edukacja']"
      />
      <v-row class="row">
        <v-spacer></v-spacer>
        <v-btn type="submit">Zapisz</v-btn>
      </v-row>
    </v-form>
  </v-card>
</template>

<style scoped>
.card {
  padding: 10px;
}
.row {
  padding: 10px;
}
</style>
