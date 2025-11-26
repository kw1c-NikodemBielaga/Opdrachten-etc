<template>
  <main class="home">
    <h1>Start pagina</h1>
    <ProductList />
  </main>
</template>

<script>
import ProductList from '@/components/ProductList.vue';

export default {
  name: 'HomeView',
  components: {
    ProductList,
  },
};
</script>