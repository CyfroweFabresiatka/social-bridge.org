import { createQuery } from '@/data/index'

export const useCompaniesQuery = () => {
  const { data: companies } = createQuery(
    ['organisations-companies'],
    () => loadCompanies(),
  );
  
  return { companies };
}

export const useNgosQuery = () => {
  const { data: ngos } = createQuery(
    ['organisations-ngos'],
    () => loadNgos(),
  );

  return { ngos };
}

async function loadCompanies() {
  const data = await import('./companies.json');
  return <Company[]>data.default;
}

async function loadNgos() {
  const data = await import('./ngos.json');
  return <Ngo[]>data.default;
}

export interface Company {
  slug: string;
  name: string;
  city: string;
}

export interface Ngo extends Company {
}
