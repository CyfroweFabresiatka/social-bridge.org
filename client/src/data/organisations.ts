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

export const useNgoQuery = (slug: string) => {
  const { data, isLoading, error } = createQuery(
      ['ngos', slug],
      () => loadNgo(slug)
  );

  return { data, isLoading, error };
}

export const useCompanyQuery = (slug: string) => {
  const { data, isLoading, error } = createQuery(
      ['company', slug],
      () => loadCompany(slug)
  );

  return { data, isLoading, error };
}

async function loadCompanies() {
  const data = await import('./companies.json');
  return <Company[]>data.default;
}

async function loadNgos() {
  const data = await import('./ngos.json');
  return <Ngo[]>data.default;
}

async function loadNgo(slug: string) {
  const ngos = await loadNgos();
  return ngos.find(x => x.slug === slug) ?? null;
}

async function loadCompany(slug: string) {
  const cmp = await loadCompanies();
  return cmp.find(x => x.slug === slug) ?? null;
}

export interface Company {
  slug: string;
  name: string;
  city: string;
  tags: string[];
}

export interface Ngo extends Company {
}
