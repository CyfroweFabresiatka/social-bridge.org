<script setup lang="ts">
import { ref, watch } from 'vue'
//@ts-ignore
import v from 'voca'

//const { addMutationFn } = useProjectMutation()

const name = ref<string>('')
const slug = ref<string>('')
const description = ref<string>('')
const budgetAmountFrom = ref<number>(0)
const budgetAmountTo = ref<number>(0)
const plannedStartDate = ref<any>('')
const plannedEndDate = ref<any>('')
const locationsIds = ref<number[]>([0, 1])
const tagsIds = ref<number[]>([0, 1])

function valid() {
  return name.value.trim() !== ''
}

async function onSubmit() {
  name.value = '';
  description.value = '';
  budgetAmountFrom.value = 0;
  budgetAmountTo.value = 0;
  window.scrollTo({ top: 0, behavior: 'smooth' });
}

watch(name, (newValue) => {
  slug.value = v.slugify(newValue)
})
</script>

<template>
  <v-form :value="valid()" class="form">
    <v-row>
      <v-col>
        <v-text-field v-model="name"
                      name="name"
                      :label="$t('project.project_name')"
                      density="compact"
                      variant="solo-filled"
                      rounded="pill"
        />
          <v-text-field
            v-model="slug"
            label="Slug"
            density="compact"
            variant="solo-filled"
            rounded="pill"
            readonly />
          <v-textarea 
            v-model="description"
            label="Description"
            variant="solo-filled"
            density="compact"
          />
        <v-row>
          <v-col>
            <v-text-field
              v-model="budgetAmountFrom"
              label="Budget Amount From"
              type="number"
              variant="solo-filled"
              rounded="pill"
            />
          </v-col>
          <v-col>
            <v-text-field
              v-model="budgetAmountTo"
              label="Budget Amount To"
              type="number"
              variant="solo-filled"
              rounded="pill"
            />
          </v-col>
        </v-row>
          <v-date-picker></v-date-picker>
      </v-col>
    </v-row>
    <v-spacer />
    <v-row class="btn-container">
      <v-btn color="primary" small :disabled="!valid()" @click="onSubmit">
        {{ $t('project.addProject') }}
      </v-btn>
    </v-row>
    <v-spacer />
  </v-form>
</template>

<style scoped>
.form {
  margin: 0 auto;
  width: 50%;
}

.btn-container {
  margin-bottom: 30px;
}
</style>
